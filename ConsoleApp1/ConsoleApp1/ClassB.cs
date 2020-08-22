namespace ConsoleApp1
{
    public class ClassB : ClassA
    {
        public static bool IsDerivedClass(ClassA classA)
        {
            if (classA is ClassB)
                return true;
            return false;
        }

        public static bool IsBaseClass(ClassA classA)
        {
            if (classA is ClassA)
                return true;
            return false;
        }

        public static bool IsClassABaseClassOfClassB() =>true;

        public static bool IsDerivedClass(ClassB classB)
        {
            if (classB is ClassB)
                return true;
            return false;
        }

    }
}