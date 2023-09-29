using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestTask.Enums;

//This is a converter to convert values from the UserStatus enumeration to numeric values when saving to the database and back when loading from the database.
namespace TestTask.Data
{
    public class UserStatusConverter : ValueConverter<UserStatus, int>
    {
        public UserStatusConverter()
            : base(
                  status => (int)status,
                  value => (UserStatus)value)
        {
        }
    }
}
