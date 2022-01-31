using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace prenatal.mobile.app.Validations
{
    public class InfoValidationBehavior:Behavior<Entry>
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
            
            var new_value = e.NewTextValue;
            var Entry = sender as Entry;
                       
            if (new_value.Length>0 && new_value.Length<30)
            {
                Entry.BackgroundColor = Color.Transparent;
                Entry.Parent.FindByName<Button>("subButton").IsEnabled = true;
            }
            else
            {
                Entry.BackgroundColor = Color.Red;
                Entry.Parent.FindByName<Button>("subButton").IsEnabled = false;
            }
        }
    }
}
