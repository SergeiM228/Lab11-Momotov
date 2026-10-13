// // int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// // int target = 1093;

// // bool found = false;

// // foreach (int number in recordBooks)
// // {
// //     if (number == target)
// //     {
// //         found = true;
// //         break;
// //     }
// // }

// // Console.WriteLine(found
// //     ? "Студент найден"
// //     : "Студент не найден");



// int[] temperatures = { 12, 5, 18, 0, 52, 21, 4, 49 };

// int index = -1;

// for (int i = 0; i < temperatures.Length; i++)
// {
//     // Допишите условие:
//     // 1. Проверьте, отрицательное ли число.
//     // 2. Если да, сохраните индекс i.
//     // 3. Завершите цикл.
// }
// if (index >= 0) {
//     Console.WriteLine($"Индекс: {index}");
// } else {
//     Console.WriteLine("Отрицательных чисел нет");
// }


// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;
// int submittedCount = 0;

// foreach (int points in pointsPerLab)
// {
//     if (points < 0)
//     {
//         submittedCount++;
//         continue;
//     }

//     sum += points;
// }
// Console.WriteLine($"Сумма баллов: {sum}");

// Console.WriteLine($"Количество сданных работ: {submittedCount}");

