using System.ComponentModel.DataAnnotations;

namespace Validation.Annotations
{
    // якщо не вистачає стандартних атрибутів, можна зробити власний кастомний атрибут
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class MyAuthorsAttribute : ValidationAttribute
    {
        // масив для збереження авторів
        private static string[]? myAuthors;

        public MyAuthorsAttribute(string[] Authors)
        {
            myAuthors = Authors;
        }

        public override bool IsValid(object? value)
        {
            if (value != null)
            {
                string? strval = value.ToString();
                for (int i = 0; i < myAuthors?.Length; i++)
                    if (strval == myAuthors[i])
                        return true;
            }
            return false;
        }
    }
}
