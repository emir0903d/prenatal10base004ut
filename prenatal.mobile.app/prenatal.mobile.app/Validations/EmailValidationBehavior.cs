using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace prenatal.mobile.app.Validations
{
    public class EmailValidationBehavior:Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += Bindable_TextChanged;
        }
        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= Bindable_TextChanged;
        }
        private void Bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
            var value = e.NewTextValue;
            //var emailPattern = "^(?(\")(\".+?(?<!\\)\"@)| (([0 - 9a - z]((\\.(? !\\.)) |[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$";
            var emailEntry = sender as Entry;

            if (Regex.IsMatch(value, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$") && value.Length>0)
            {
                emailEntry.BackgroundColor = Color.Transparent;
                emailEntry.Parent.FindByName<Button>("subButton").IsEnabled = true;
            }
            else
            {
                emailEntry.BackgroundColor = Color.Red;
                emailEntry.Parent.FindByName<Button>("subButton").IsEnabled = false;
            }
        }
    }
}
