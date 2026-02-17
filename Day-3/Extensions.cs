namespace MethodsAndMembersExercises
{
    public static class StringExtensions
    {
        public static int? ToIntOrNull(this string s)
        {
            if (int.TryParse(s, out int result))
                return result;

            return null;
        }

        public static bool IsPalindrome(this string s)
        {
            if (string.IsNullOrEmpty(s)) return false;

            var reversed = new string(s.Reverse().ToArray());
            return s.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
}
