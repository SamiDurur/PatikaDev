# Proje1Sorting
Veri Yapıları ve Algoritma projesi

# Proje 1

[22,27,16,2,18,6] -> Insertion Sort
---
## 1- Yukarı verilen dizinin sort türüne göre aşamalarını yazınız.

- 1: [22,27,16,2,18,6]
- 2: [2,27,16,22,18,6]
- 3: [2,6,16,22,18,27]
- 4: [2,6,16,18,22,27]

## 2- Big-O gösterimini yazınız.
- 1: [22,27,16,2,18,6] n
- 2: [2,27,16,22,18,6] n-1
- 3: [2,6,16,22,18,27] n-3
- 4: [2,6,16,18,22,27] 1

- ### O(N^2)

## 3- Time Complexity: Average case: Aradığımız sayının ortada olması,Worst case: Aradığımız sayının sonda olması, Best case: Aradığımız sayının dizinin en başında olması.

- Average Case: 16, 18 - O(n^2)
- Worst Case: 27 - O(n^2)
- Best Case: 2 - O(n)

## 4- Dizi sıralandıktan sonra 18 sayısı hangi case kapsamına girer? Yazınız.
- Average Case

---

## [7,3,5,8,2,9,4,15,6] dizisinin Insertion Sort'a göre ilk 4 adımını yazınız.

- 1: [2,3,5,8,7,9,4,15,6]
- 2: [2,3,4,8,7,9,5,15,6]
- 3: [2,3,4,5,7,9,8,15,6]
- 4: [2,3,4,5,6,9,8,15,7]