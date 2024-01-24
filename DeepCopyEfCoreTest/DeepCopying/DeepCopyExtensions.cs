namespace DeepCopyEfCoreTest.DeepCopying
{
    public static class DeepCopyExtensions
    {
        public static T DeepCopy<T>(this T toCopy)
        {
            return DeepCopyService.DeepCopy(toCopy);
        }
    }
}