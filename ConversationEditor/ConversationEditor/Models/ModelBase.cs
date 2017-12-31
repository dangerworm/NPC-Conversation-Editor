using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ConversationEditor.Models
{
    public class ModelBase: INotifyPropertyChanged
    {
        public bool IsDirty { get; protected set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Clean()
        {
            IsDirty = false;
        }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetValue<T>(ref T property, T value, string propertyName)
        {
            if (value == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(propertyName))
            {
                throw new ArgumentNullException(nameof(propertyName), @"Parameter cannot be null.");
            }

            if (value.Equals(property))
            {
                return;
            }
            property = value;
            OnPropertyChanged(propertyName);
        }
    }
}
