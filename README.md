# Итоговая проверочная работа
1. Задаем размер исходного массива.
2. Создаем новый пустой массив и к каждому индексу присваевыем новое значение.
3. Создаем метод для вывода массива на экран в который передаются массивы:
 * ыводим квадратную скобку в начале массива.
 * Далее создаем цикл при i = 0, цикл будет работать пока i меньше длинны входного массива, в конце цикла к i прибавляем 1.
 * Далее делаем цикл в цикле, если меньше длинны входного массивы минус 1, то мы выводим наше значение следующим образом {array[i]}, (т.е. сначала идет элемент, после него запятая) иначе выводим {array[i]}] c закрывающей скобкой.
4. Создаем метод, который будет определять длинну массива в который передается массив и воззвращать число:
 * Вводим новую переменную count в которую будем записывать количество элементов с длинной меньшей или равной 3-м.
 * Создаем цикл при i = 0, цикл будет работать пока i меньше длинны входного массива, в конце цикла к i прибавляем 1.
 * Создаем цик в цикле с условием, если элемент с индексом i меньше или равен трем, то к count мы прибавляем 1.
 * Далее возвращаем значение count.
5. Создаем метод, который будет формировать новый массив в соответствии с условием задания. В него будут передаваться массив и размер нового массива из метода №2, а возвращаться новый массив.
 * Создаем новый пустой массив.
 * Вводим новую переменную index, равную нулю, которая будет отвечать за индекс нового массива.
 * Создаем цикл при i = 0, цикл будет работать пока i меньше длинны входного массива, в конце цикла к i прибавляем 1.
 * Создаем цикл в цикле с условием если элемент с индекс i меньше либо равно 3-м, то элемент нового массива с индексом index    будет равен элементы старого массива с индексом i, к index прибавляем 1.
 * После окончания цикла возвращаем новый массив.
6. Вводим новую переменную newSize, которая вызывает метод FindSizeOfArr(arr) и передает исходный массив, и получает обратно колличество элементов массива, размер которых меньше либо равен 3-м.
7. Вводим новую переменную result, которая вызывает метод FindElements и передает размер нового массива в исходный массив.
8. С помощью метода PrintArray выводим исходный массив на экран.
9. С помощью метода PrintArray выводим новый массив на экран.

