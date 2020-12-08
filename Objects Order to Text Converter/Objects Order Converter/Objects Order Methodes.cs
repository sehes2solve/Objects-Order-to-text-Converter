using System;

namespace Objects_Order_Converter
{
    class Objects_Order_Methodes
    {
        public string Objects_Order_Converter(string order,string obj,string lang)
        {
            if (lang == "EN")
                return "The " + Order_Converter_En(Convert.ToDecimal(order)) + " " + obj;
            else
                return "ال" + obj  + " "+ Order_Converter_Ar(Convert.ToDecimal(order));
        }
        /// <summary>
        /// converts a decimal number that is integral only into a text in english
        /// </summary>
        /// <param name="integer">decimal carries the value of the integer that will be converted</param>
        /// <returns>returns the equivalent text for the integer number</returns>
        public string Integer_Converter_En(decimal integer)
        {
            if (integer == 0)// check if the number is 0.
                return "";// returns nothing.
            else
            {
                string text = "";//set string that the value of each three digits of the number will accumlate in it.
                if ((long)integer / 1000000000 > 0)//check whether the 3 digits (that describe the billion value) there value not zero.
                {
                    text = Integer_Converter_En((long)integer / 1000000000) + " Billion";
                    //add for text the text conversion of the three digits (but starts from units level) and add word billion.
                    integer %= 1000000000;//remove from the integer the three digit of billion level.
                }
                if ((int)integer / 1000000 > 0)//check whether the 3 digits (that describe the Million value) there value not zero.
                {
                    text += (text != "" ? " " : "") + Integer_Converter_En((int)integer / 1000000) + (text != "" ? " " : "") + " Million";
                    //add for text the text conversion of the three digits (but starts from units level) and add word Milion.
                    integer %= 1000000;//remove from the integer the three digit of Million level.
                }
                if ((int)integer / 1000 > 0)//check whether the 3 digits (that describe the Million value) there value not zero.
                {
                    text += (text != "" ? " " : "") + Integer_Converter_En((int)integer / 1000) + " Thousand";
                    //add for text the text conversion of the three digits (but starts from units level) and add word thousand.
                    integer %= 1000;//remove from the integer the three digit of thousand level.
                }
                if ((int)integer / 100 > 0)//check whether the hundered digit isn't zero.
                {
                    text += (text != "" ? " " : "") + Integer_Converter_En((int)integer / 100) + " hundered";
                    //add for text the text conversion of the hundered digit (but starts as unit) and add word hundered.
                    integer %= 100;//remove from the integer the hundered digit.
                }
                if (integer == 0)//check whether the units & tenth digits summation value is zero.
                    return text;//return the text reulted from digits from hundered to billion.

                string[] units_tenth = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                //intialize array carries the name of numbers less than twenty.
                string[] tenth = new string[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                //intialize array that carry the names of tenth digits except that first the one as theeach combination of it with units gives specified name.
                if (integer < 20)//check whether the integer value is less than twenty.
                {
                    text += (text != "" ? " " : "") + units_tenth[(int)integer];//add the name of the number that less than 20 and it's value is integer.
                }
                else
                {
                    text += (text != "" ? " " : "") + tenth[(int)integer / 10];//get the value of the tenth digit only and add it's name as a tenth.
                    if (integer % 10 > 0)//check whether the units digit isn't zero.
                        text += "-" + Integer_Converter_En(integer % 10);//add dash then the name of the digit in units digit.
                }


                return text;

            }
        }
        public string Order_Converter_En(decimal order)
        {
            if (order % 100 == 0 || order % 1000 == 0 || order % 1000000 == 0)
                return Integer_Converter_En(order) + "th";
            else
            {
                if (order % 10 == 0)
                {
                    string text = Integer_Converter_En(((long)order / 100) * 100);
                    if (text != "")
                        text += " ";
                    if (order % 100 != 10)
                        return text + Integer_Converter_En(order % 100).Replace("y", "ieth");
                    else
                        return text + (text == "" ? "" : " ") + "tenth";
                }
                else
                {
                    string[][] unit_exc = new string[2][] {
                    new string[] { "1", "2", "3", "5", "8", "9" },
                    new string[] { "first", "second", "third", "fifth", "eighth", "ninth"}};
                    int exc_ind = Array.IndexOf(unit_exc[0], (order % 10).ToString());
                    if (exc_ind != -1 && order % 100 - order % 10 != 10)
                    {

                        if (order % 100 - order % 10 == 0)
                        {
                            string text = Integer_Converter_En(((long)order / 100) * 100);
                            return text + (text == "" ? "" : " ") + unit_exc[1][exc_ind];
                        }
                        else
                        {
                            return Integer_Converter_En(((long)order / 10) * 10) + "-" + unit_exc[1][exc_ind];
                        }
                    }
                    if (order % 100 == 12)
                    {
                        string text = Integer_Converter_En(((long)order / 100) * 100);
                        return text + (text == "" ? "" : " ") + "twelfth";
                    }
                    else
                        return Integer_Converter_En(order) + "th";
                }

            }
        }
        /// <summary>
        /// converts a decimal number that is integral only into a text in Arabic
        /// </summary>
        /// <param name="integer">decimal carries the value of the integer that will be converted</param>
        /// <returns>returns the equivalent text for the integer number</returns>
        public string Integer_Converter_Ar(decimal integer)
        {
            if (integer == 0)// check if the number is 0.
                return "";
            string text = "";//set string that the value of each three digits of the number will accumlate in it.
            if ((long)integer / 1000000000 > 0)//check whether the 3 digits (that describe the billion value) there value not zero.
            {
                if ((long)integer / 1000000000 == 1)//check whether those digits value is 1.
                    text += " مليار";//add the suiting word according to grammer.
                else if ((long)integer / 1000000000 == 2)//check whether those digits value is 2.
                    text += " ملياران";//add the suiting word according to grammer.
                else if ((long)integer / 1000000000 < 11)//check whether those digits value is less than 11.
                    text += Integer_Converter_Ar((long)integer / 1000000000) + " مليارات";
                //add for text the text conversion of the three digits (but starts from units level) and suiting word grammarly.
                else
                    text += Integer_Converter_Ar((long)integer / 1000000000) + " ملياراَ";
                //add for text the text conversion of the three digits (but starts from units level) and suiting word grammarly.
                integer %= 1000000000;//remove from the integer the three digit of billion level.
            }
            if ((int)integer / 1000000 > 0)//check whether the 3 digits (that describe the Million value) there value not zero.
            {
                if (text != "")//check whether there's value in text from pervious condition.
                    text = text + " و ";//add linking char according to grammer.
                if ((int)integer / 1000000 == 1)//check whether those digits value is 1.
                    text = " مليون" + text;//add the suiting word according to grammer.
                else if ((int)integer / 1000000 == 2)//check whether those digits value is 2.
                    text += " مليونان";//add the suiting word according to grammer.
                else if ((int)integer / 1000000 < 11)//check whether those digits value is less than 11.
                    text += Integer_Converter_Ar((int)integer / 1000000) + " ملايين";
                //add for text the text conversion of the three digits (but starts from units level) and suiting word grammarly.
                else
                    text += Integer_Converter_Ar((int)integer / 1000000) + " مليوناً";
                // add for text the text conversion of the three digits(but starts from units level) and suiting word grammarly.
                integer %= 1000000;// remove from the integer the three digit of million level.
            }
            if ((int)integer / 1000 > 0)//check whether the 3 digits (that describe the thousand value) there value not zero.
            {
                if (text != "")//check whether there's value in text from pervious conditions.
                    text = text + " و ";//add linking char according to grammer.
                if ((int)integer / 1000 == 1)//check whether those digits value is 1.
                    text += "ألف";//add the suiting word according to grammer.
                else if ((int)integer / 1000 == 2)//check whether those digits value is 2.
                    text += "ألفان ";//add the suiting word according to grammer.
                else if ((int)integer / 1000 < 11)//check whether those digits value is less than 11.
                    text += Integer_Converter_Ar((int)integer / 1000) + " ألاف";
                //add for text the text conversion of the three digits (but starts from units level) and suiting word grammarly.
                else
                    text += Integer_Converter_Ar((int)integer / 1000) + " ألفاً";
                // add for text the text conversion of the three digits(but starts from units level) and suiting word grammarly.
                integer %= 1000;// remove from the integer the three digit of thousand level.
            }
            if ((int)integer / 100 > 0)//check whether the hundered digit isn't zero.
            {
                if (text != "")//check whether there's value in text from pervious conditions.
                    text = text + " و ";//add linking char according to grammer.
                string[] hundered = new string[] { "صفر", "مائة", "مائتان", "ثلاثمائة", "أربعمائة", "خمسمائة", "ستمائة", "سبعمائة", "ثمانمائة", "تسعمائة" };
                //intialize array names of digits in hundereds according to grammer.
                text += hundered[(int)integer / 100];//add the name of the digit in hundered level
                integer %= 100;// remove the hundered digit.
            }
            if (integer == 0)//check whether the units & tenth digits summation value is zero.
                return text;//return the text reulted from digits from hundered to billion.
            if (text != "")//check whether there's value in text from pervious conditions.
                text = text + " و ";//add linking char according to grammer.
            string[] units = new string[] { "صفر", "واحد", "اثنان", "ثلاثة", "أربعة", "خمسة", "ستة", "سبعة", "ثمانية", "تسعة", "عشرة" };
            //array carry the names of numbers at units digit and the name of first one in tenth digit with zero combination of units digit.
            string[] tenth = new string[] { "صفر", "عشرة", "عشرون", "ثلاثون", "أربعون", "خمسون", "ستون", "سبعون", "ثمانون", "تسعون" };
            //array carry the names of numbers at tenth digit.
            if (integer <= 10)//check whether the total value of the two digits is less than or equal ten.
                text = text + units[(int)integer];//add the name of the digit from the array of units
            else if (integer < 20)//check whether the total value of two digits is less than 20
            {
                if (integer == 11)//check whether it's 11 
                    text = text + "أحد عشر";//add name of eleven
                else if (integer == 12)//check whther it's twelve
                    text = text + "اثنا عشر";//add name of twelve
                else
                    text = text + units[(int)integer % 10] + " عشر";//add the units name of the units digit and add the suiting constan word according to grammer.
            }
            else
            {
                if ((int)integer % 10 != 0)//check whether the units digit is not zero.
                    text += units[(int)integer % 10] + " و " + tenth[(int)integer / 10];
                // add the tenth name of the tenth digit and linking char and the units name of units digit.
                else
                    text += tenth[(int)integer / 10];//add the tenth name of tenth digit.
            }

            return text;
        }
        public string Order_Converter_Ar(decimal order)
         {
            if (order > 100)
                return Integer_Converter_Ar(order);
            else
            {
                string[] units = new string[]
                {"الحادى",
                "الثانى",
                "الثالث",
                "الرابع",
                "الخامس",
                "السادس",
                "السابع",
                "الثامن",
                "التاسع",
                "العاشر"};
                if (order < 11)
                {
                    if (order == 1)
                        return "الأول";
                    return units[(int)order - 1];
                }
                else if (order < 20)
                    return units[(int)order % 10 - 1] + " عشر";
                else if (order < 100)
                {
                    string[] tenth = new string[]
                    {"العشرون",
                    "الثلاثون",
                    "الاربعون",
                    "الخمسون",
                    "الستون",
                    "السبعون",
                    "الثمانون",
                    "التسعون"};
                    if (order % 10 == 0)
                        return tenth[((int)order / 10) - 2];
                    else
                        return units[(int)order % 10 - 1] + " و " + tenth[(int)order / 10 - 2];
                }
                else
                    return "المئة";
            }
         }
        public bool Validation(string number, string lang, out int err_id, out string err_message)
        {
            number = number.Trim();
            lang = lang.Trim();
            if (Value_Validation(number, out err_id, out err_message))
            {
                if (Language_Validation(lang, out err_id, out err_message))
                    return true;
            }
            return false;
        }
        /// <summary>
        /// defines whether the numerical value that will be converted is valid or invalid
        /// ,save error message incase error occured & save id for that message.
        /// err_id : err_message
        ///   0    | "success"
        ///   1    | "input length out of range"
        ///   2    | "starting with seprator"
        ///   3    | "ending with seprator"
        ///   4    | "wrong inputted char"
        ///   5    | "max number of dots exceeded"
        ///   6    | "max number of commas exceeded"
        ///   7    | "comma in fractional part"
        ///   8    | "seprator dublication"
        ///   9    | "fractional part is out of length range"
        ///   10   | "integral part is out of length range"
        ///   11   | "Value is out of range"
        /// </summary>
        /// <param name="number">the number that will beconverted</param>
        /// <param name="err_id">int id of error type occured</param>
        /// <param name="err_message">string save message explain that type of error</param>
        /// <returns>returns true if the number was valid otherwise false</returns>
        public bool Value_Validation(string number, out int err_id, out string err_message)
        {
            number = number.Trim();// remove the spaces added on start or end of the string of number.
            if (number.Length > 0 && number.Length <= 14)//check whether length of the string doesn't exceed max length or if string is empty.
            {
                if (number[0] != ',')//check if the string doesn't start with seprator.
                {
                    if (number[number.Length - 1] != ',')//check whther the string doesn't end with seprator.
                    {
                        int comas_no = 0;//sets counters for number of dots & number of commas in string.
                        foreach (char number_char in number)//loops on each char of the string.
                        {
                            if (number_char >= '0' && number_char <= '9')//check if the char is number.
                                continue;
                            else if (number_char == ',')//check if the char is comma.
                            {
                                comas_no++;// increment the counter of commas.
                                if (comas_no > 3)//chek whether comma counter more than avaliable number.
                                {
                                    err_id = 5;//set id of the error.
                                    err_message = "max number of commas exceeded";// set error message describe the error type.
                                    return false;
                                }
                                if (Array.IndexOf(number.ToCharArray(), number_char) != number.Length - 1)//check whether char not last one in string.
                                {
                                    if (number[(Array.IndexOf(number.ToCharArray(), number_char) + 1)] == ',' )
                                    {
                                        err_id = 6;//set id of the error
                                        err_message = "seprator dublication";// set error message describe the error type.
                                        return false;
                                    }
                                }
                                continue;
                            }
                            else
                            {
                                err_id = 4;//set id of the error.
                                err_message = "wrong inputted char";// set error message describe the error type.
                                return false;
                            }
                        }
                        number = number.Replace(",", "");//remove the commas.
                        if (number.Length <= 12)//check if the integral part length doesn't exceed max limit.
                        {
                            if (Convert.ToDecimal(number) >= 1)//check if the value of the number not less than 1.
                            {
                                err_id = 0;//set error id of not occuring error.
                                err_message = "success"; ;//set message of success for validation.
                                return true;
                            }
                            else
                            {
                                err_id = 7;//set id of the error.
                                err_message = "Value is out of range";// set error message describe the error type.
                                return false;
                            }
                        }
                        else
                        {
                            err_id = 8;//set id of the error.
                            err_message = "lenght of the number is out of range";// set error message describe the error type.
                            return false;
                        }
                    }
                    else
                    {
                        err_id = 3;//set id of the error.
                        err_message = "ending with seprator";// set error message describe the error type.
                        return false;
                    }
                }
                else
                {
                    err_id = 2;//set id of the error.
                    err_message = "starting with seprator";// set error message describe the error type.
                    return false;
                }
            }
            else
            {
                err_id = 1;//set id of the error.
                err_message = "input length out of range";// set error message describe the error type.
                return false;
            }
        }
        /// <summary>
        /// defines whether the language (that the number will be convrted in it's format) is valid or invalid
        /// ,save error message incase error occured & save id for that message.
        /// /// err_id : err_message
        ///    0   | "success"
        ///   13   | "language field is empty"
        ///   14   | "undefined language"
        /// </summary>
        /// <param name="lang">string carry the indicator of the language</param>
        /// <param name="err_id">int id of error type occured</param>
        /// <param name="err_message">string save message explain that type of error</param>
        /// <returns>returns true the indicator of language is right</returns>
        public bool Language_Validation(string lang, out int err_id, out string err_message)
        {
            lang = lang.Trim();// the spaces on the borders of language string
            if (lang == "AR" || lang == "EN")//Check whther the string carry defined indicator
            {
                err_id = 0;
                err_message = "success";//set error id of not occuring error.
                return true;//set message of success for validation.
            }
            else
            {
                if (lang.Length == 0)
                {
                    err_id = 9;//set id of the error.
                    err_message = "language field is empty";// set error message describe the error type.
                    return false;
                }
                err_id = 10;//set id of the error.
                err_message = "undefined language";// set error message describe the error type.
                return false;
            }
        }
    }
}
