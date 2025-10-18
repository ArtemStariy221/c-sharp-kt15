//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace App.Topics.Enumerators.T2_CustomZip
//{
//    public static class EnumerableEx
//    {
//        public static IEnumerable<(TFirst First, TSecond Second)> ZipWithPadding<TFirst, TSecond>(
//            this IEnumerable<TFirst> first,
//            IEnumerable<TSecond> second,
//            TFirst firstPad,
//            TSecond secondPad)
//        {
//            if (first == null)
//                throw new ArgumentNullException(nameof(first));
//            if (second == null)
//                throw new ArgumentNullException(nameof(second));

//            return ZipWithPaddingIterator(first, second, firstPad, secondPad);
//        }

//        private static IEnumerable<(TFirst First, TSecond Second)> ZipWithPaddingIterator(
//            IEnumerable<TFirst> first,
//            IEnumerable<TSecond> second,
//            TFirst firstPad,
//            TSecond secondPad)
//        {
//            using var firstEnumerator = first.GetEnumerator();
//            using var secondEnumerator = second.GetEnumerator();

//            bool hasFirst, hasSecond;

//            do
//            {
//                hasFirst = firstEnumerator.MoveNext();
//                hasSecond = secondEnumerator.MoveNext();

//                // Если обе последовательности закончились, выходим
//                if (!hasFirst && !hasSecond)
//                    yield break;

//                // Возвращаем пару с заполнением для закончившейся последовательности
//                yield return (
//                    hasFirst ? firstEnumerator.Current : firstPad,
//                    hasSecond ? secondEnumerator.Current : secondPad
//                );
//            }
//            while (hasFirst || hasSecond);
//        }
//    }
//}