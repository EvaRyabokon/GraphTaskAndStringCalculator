# The Graph Solution
----
Let's create a dictionary where the key is the vertex number and the value is the number of parents. 

Then let's go through all the edges.
If the parent is not in the dictionary then put it in the dictionary with the zero value. 

If the child is not in the dictionary then put it in the dictionary with the value of one, otherwise we increase the number of its parents by 1.

To find all vertices without parents one needs to select keys with values of 0 from the dictionary.

To find all vertices with a single parent one needs to select keys with values of 1 from the dictionary.

The mathematical expectation of the running time is O(n), because a hash table is used.
The memory complexity of the algorithm is O(n): linearly of the number of vertices.


----

Заведем словарь, где ключом будет являться номер вершины, а значением – количество родителей. 

Переберем все ребра. Если родителя нет в словаре, то кладем его в словарь со значением ноль.

Если ребенка нет словаре, то положим его в словарь со значением один, иначе увеличиваем количество его родителей на 1.

Чтобы найти все вершины без родителей, нужно выбрать из словаря ключи со значениями 0.

Чтобы найти все вершины с одним родителем, нужно выбрать из словаря ключи со значениями 1.

Математическое ожидание времени работы O(n), потому что используется хэш-таблица.
Сложность алгоритма по памяти O(n): линейно от количества вершин.
----
