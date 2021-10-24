using Lemure.Delegates;

namespace Lemure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var yuri = new Person("Yuri Melo", 23);
            ExampleDelegate.GetInformation(yuri, yuri.OneMoreAge, yuri.RiseSalary);

            #region TransformStringInUpperCase
            ExampleDelegate ed = new ExampleDelegate();
            ed.TransformInto(ed.books, ed.TransformIntoUpcase);
            ed.TransformInto(ed.books, ed.TransformIntoLowerCase);
            ed.TransformInto(ed.books, ed.ApplyTrim);
            #endregion
        }
    }
}
