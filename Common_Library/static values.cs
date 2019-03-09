using System;

namespace Common_Library
{
    public static class Used_Numeral_Systems
    {
        public static Numeral_System_Group[] Numeral_Systems
        {
            get
            {
                return new Numeral_System_Group[] { new Numeral_System_Group(-3, -2), new Numeral_System_Group(1, 64) };
            }
        }
    }

    public struct Numeral_System_Group
    {
        public sbyte starting_Code;

        public sbyte finale_Code;

        public Numeral_System_Group(sbyte starting, sbyte finale)
        {
            if (starting <= finale)
            {
                starting_Code = starting;

                finale_Code = finale;
            }
            else
            {
                starting_Code = finale;

                finale_Code = starting;
            }
        }
    }
}