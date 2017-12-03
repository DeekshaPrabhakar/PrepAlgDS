using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Strings
{
    class PrettyJSON
    {
        public static void Run()
        {
            String input = "{A:\"B\",C:{D:\"E\",F:{G:\"H\",I:\"J\"}}}";
            Console.WriteLine("PrettyJSON for " + input);
            Util.DisplayJSON(prettyJSON(input));

            input = "[\"foo\", {\"bar\":[\"baz\",null,1.0,2]}]";
            Console.WriteLine("PrettyJSON for " + input);
            Util.DisplayJSON(prettyJSON(input));

            input = "{\"id\":100,\"firstName\":\"Jack\",\"lastName\":\"Jones\",\"age\":12}";
            Console.WriteLine("PrettyJSON for " + input);
            Util.DisplayJSON(prettyJSON(input));

            input = "{\"attributes\":[{\"nm\":\"ACCOUNT\",\"lv\":[{\"v\":{\"Id\":null,\"State\":null},\"vt\":\"java.util.Map\",\"cn\":1}],\"vt\":\"java.util.Map\",\"status\":\"SUCCESS\",\"lmd\":13585},{\"nm\":\"PROFILE\",\"lv\":[{\"v\":{\"Party\":null,\"Ads\":null},\"vt\":\"java.util.Map\",\"cn\":2}],\"vt\":\"java.util.Map\",\"status\":\"SUCCESS\",\"lmd\":41962}]}";
            Console.WriteLine("PrettyJSON for " + input);
            Util.DisplayJSON(prettyJSON(input));

            Console.WriteLine();
        }
        private static List<string> prettyJSON(string A)
        {
            List<string> json = new List<string>();

            char[] str = A.ToCharArray();
            bool isOpen = false;
            bool isClose = false;
            StringBuilder indentation = new StringBuilder();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString().Trim().Length > 0)
                {
                    isOpen = (str[i] == '{' || str[i] == '[');
                    isClose = (str[i] == '}' || str[i] == ']');

                    if (isOpen || isClose)
                    {
                        if (isOpen)
                        {
                            json.Add(indentation.ToString() + str[i].ToString());
                            indentation.Append("\t");
                            sb = new StringBuilder();
                        }
                        else
                        {
                            if (!String.IsNullOrEmpty(sb.ToString()))
                            {// for cases where there is more than one attribute
                                json.Add(indentation.ToString() + sb.ToString());
                                sb = new StringBuilder();
                            }
                            if (indentation.Length > 0)
                            {
                                indentation.Remove(0, 1);
                            }
                            if (i + 1 < str.Length && str[i + 1] == ',')
                            {
                                json.Add(indentation.ToString() + str[i].ToString() + str[i + 1].ToString());
                            }
                            else
                            {
                                json.Add(indentation.ToString() + str[i].ToString());
                            }
                        }
                    }
                    else
                    {
                        if (str[i] == ',')
                        {
                            if (i - 1 >= 0 && str[i - 1] == '}' || str[i - 1] == ']')
                            {
                                //comma has already been appended when the brackets were closed
                            }
                            else
                            {
                                json.Add(indentation.ToString() + sb.ToString() + str[i].ToString());
                                sb = new StringBuilder();
                            }
                        }
                        else if (str[i] == ':' && i + 1 < str.Length && (str[i + 1] == '{' || str[i + 1] == '['))
                        {
                            json.Add(indentation.ToString() + sb.ToString() + str[i].ToString());
                            sb = new StringBuilder();
                        }
                        else
                        {
                            sb.Append(str[i]);
                        }
                    }
                }
            }

            return json;
        }
    }
}
