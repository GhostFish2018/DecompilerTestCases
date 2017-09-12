namespace DecompilerTestCases
{
    public static class Initializers
    {
        private static CustomClass _customClass;
        private static CustomStruct _customStruct;
        private static int[] _myArray;
        private static int[][] _myJaggedArray;
        private static int[,] _myMultidimensionalArray;

        static void InitializeClass()
        {
            _customClass = new CustomClass()
            {
                StringProperty = "Test",
                CustomClassProperty = new CustomClass()
            };
        }

        static void InitializeClassThroughCtor()
        {
            _customClass = new CustomClass("Test", new CustomClass());
        }

        static void InitializeStruct()
        {
            _customStruct = new CustomStruct()
            {
                FieldOne = 1,
                FieldTwo = 2,
                FieldThree = 3,
            };
        }

        static void InitializeStructThroughCtor()
        {
            _customStruct = new CustomStruct(1, 2, 3);
        }

        static void InitializeStructOnStackThroughCtor()
        {
            var customStruct = new CustomStruct(1, 2, 3);
            _customStruct = customStruct;
        }

        static void InitializeArray()
        {
            _myArray = new int[]
            {
                0, 1, 2, 3, 4, 5
            };
        }

        static void InitializeJaggedArray()
        {
            _myJaggedArray = new int[][]
            {
                new[] {0, 1, 2, 3, 4, 5},
                new[] {6, 7, 8, 9},
                new[] {10, 11, 12, 13, 14, 15, 16, 17},
            };
        }

        static void InitializeMultiDimensionalArray()
        {
            _myMultidimensionalArray = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
            };
        }
    }
}
