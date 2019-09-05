using System;
using System.Text;

namespace Exercise_9
{
    class Program
    {
        static void Main()
        {
            //Concatenate three strings.
            string name = "Joe";
            string TechAcademy = "\"The Tech Academy\"";
            Console.WriteLine(name + " thinks " + TechAcademy + " is great!");

            //Convert a string to uppercase.
            name = name.ToUpper();
            Console.WriteLine(name);

            //Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder("As Roosevelt had said, ", 50);

            sb.Append("\n\tIt is not the critic who counts; not the man who points out how the strong man stumbles, or where the doer of deeds could have done them better.");
            sb.AppendLine(" The credit belongs to the man who is actually in the arena, whose face is marred by dust and sweat and blood, who strives valiantly;");
            sb.AppendLine(" This is new line.who errs and comes short again and again");
            sb.AppendLine(" because there is not effort without error and shortcomings; but who does actually strive to do the deed;");
            sb.AppendLine(" who knows the great enthusiasm, the great devotion, who spends himself in a worthy cause, who at the best ");
            sb.AppendLine(" knows in the end the triumph of high achievement and who at the worst,");
            sb.AppendLine(" if he fails, at least he fails while daring greatly.");
            sb.AppendLine(" So that his place shall never be with those cold and timid souls who know neither victory nor defeat.");

            Console.WriteLine(sb);

        }
    }
}
