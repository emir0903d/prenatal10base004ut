using AutoMapper;
using Google.Authenticator;
using prenatal.model;
using prenatal.webapi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public class TwoFactorAuthService : ITwoFactorAuthService
    {
        private readonly IMapper _mapper;
        private readonly Context _db;
        public TwoFactorAuthService(Context context, IMapper mapper)
        {
            _db = context;
            _mapper = mapper;
        }
        private static string TwoFactorKey(int userId)
        {
            return $"09030604+{userId}";
        }
        
        public _2FAReturnCodes Activate(User user)
        {
            //User current_user = user;// TODO: fetch signed in user from a database
            TwoFactorAuthenticator twoFactor = new TwoFactorAuthenticator();
            var setupInfo = twoFactor.GenerateSetupCode("Prenatal", user.Username, TwoFactorKey(user.Id), false, 3);
            _2FAReturnCodes returnCodes = new _2FAReturnCodes()
            {
                ManualEntryKey = setupInfo.ManualEntryKey,
                QrCodeSetupImageUrl = setupInfo.QrCodeSetupImageUrl
            };
            
            return returnCodes;
        }
        public bool Login2FA(int userId, string InputCode)
        {
            TwoFactorAuthenticator twoFactor = new TwoFactorAuthenticator();
            bool isValid = twoFactor.ValidateTwoFactorPIN(TwoFactorKey(userId), InputCode);
            if (!isValid)
            {
                return false;
            }else return true;
        }

        public bool Enable(int userId, string InputCode)
        {
            //User current_user = user; // TODO: fetch signed in user from a database
            TwoFactorAuthenticator twoFactor = new TwoFactorAuthenticator();
            bool isValid = twoFactor.ValidateTwoFactorPIN(TwoFactorKey(userId), InputCode);
            if (!isValid)
            {
                return false;
            }

            //user.TwoFactorEnabled = true;
            Users x = _db.Users.Find(userId);
            x.TwoFactorEnabled = true;
            _db.Users.Update(x);
            _db.SaveChanges();
            _db.Dispose();
            // TODO: store the updated user in database
            return true;
        }
        public bool Disable(int userId, string InputCode)
        {
            TwoFactorAuthenticator twoFactor = new TwoFactorAuthenticator();
            bool isValid = twoFactor.ValidateTwoFactorPIN(TwoFactorKey(userId), InputCode);
            if (!isValid)
            {
                return false;
            }

            Users x = _db.Users.Find(userId);
            x.TwoFactorEnabled = false;
            _db.Users.Update(x);
            _db.SaveChanges();
            _db.Dispose();        
            return true;
        }
    }
}
