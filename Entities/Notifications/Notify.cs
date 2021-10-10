using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Notifications
{
    public class Notify
    {
        public Notify()
        {
            Notifications = new List<Notify>();
        }

        [NotMapped]
        public string NameProperty { get; set; }

        [NotMapped]
        public string Message { get; set; }

        [NotMapped]
        public List<Notify> Notifications;


        public bool ValidatePropertyString(string value, string nameproperty)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(nameproperty))
            {
                Notifications.Add(new Notify
                {
                    Message = "Campo obrigatório",
                    NameProperty = nameproperty
                });

                return false;
            }

            return true;
        }

        public bool ValidatePropertyInt(int value, string nameproperty)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(nameproperty))
            {
                Notifications.Add(new Notify
                {
                    Message = "Valor deve ser maior que 0",
                    NameProperty = nameproperty
                });

                return false;
            }

            return true;
        }

        public bool ValidatePropertyDecimal(decimal value, string nameproperty)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(nameproperty))
            {
                Notifications.Add(new Notify
                {
                    Message = "Valor deve ser maior que 0",
                    NameProperty = nameproperty
                });

                return false;
            }

            return true;
        }
    }
}
