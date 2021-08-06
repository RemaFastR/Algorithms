using System;
using System.Collections.Generic;
using System.Linq;
using Algorithms;
using Algotithms;
using algo = Algotithms;

namespace ForAlgotithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[5] { 3, 5, -8, 22, 44};
         
            // Бинарный поиск.
            //Console.WriteLine(algo.SearchAlgorithms.FindWithBinarySearch(list, 22));
            
            // Сортировка выбором.
            // foreach (var item in algo.SortAlgotithms.SelectionSortBySmallest(list))
            // {
            //     Console.WriteLine(item);
            // }

            //Рекурсинавная функция расчета суммы элементов массива
            //Console.WriteLine(algo.AdditionalFunctions.CalculateArraySum(list));

            //Рекурсинавная функция подсчета количества элементов массива
            //Console.WriteLine(algo.AdditionalFunctions.GetArrayCount(list));

            //Рекурсивная функция нахождения максимального числа в массиве
            //Console.WriteLine(algo.AdditionalFunctions.GetMaxArrayValue(list, list.Length));
        
            // Быстрая сортировка с рекурсией
            // foreach (var item in algo.SortAlgotithms.QuickSort(list))
            // {
            //     Console.WriteLine(item);
            // }

            // Пример поиска в ширину
            //BreadthFirstSearch();

            //Алгоритм Дейкстры
            DijkstraAlgorithm();
        }

        #region Пример поиска в ширину
        // Пример поиска в ширину
        private static void BreadthFirstSearch(){
            Graph<string, List<string>> graph = new algo.Graph<string, List<string>>();
            graph.AddTop("you", new List<string>(){ "alice", "bob", "claire" });
            graph.AddTop("bob", new List<string>(){ "anuj", "peggy" });
            graph.AddTop("alice", new List<string>(){ "peggy" });
            graph.AddTop("claire", new List<string>(){ "thom", "jonny" });
            graph.AddTop("anuj", new List<string>(){  });
            graph.AddTop("peggy", new List<string>(){  });
            graph.AddTop("thom", new List<string>(){  });
            graph.AddTop("jonny", new List<string>(){  });

            var items = graph.Tops["you"];
            List<string> searched = new List<string>();
            Deque<string> searchDeq = new Deque<string>();
            foreach (var item in items)
            {
                searchDeq.AddFirst(item);
            }

            while (searchDeq.GetCount() > 0)
            {
                var person = searchDeq.RemoveFirst();
                if (!searched.Any(t => t == person))
                {
                    if (PersonIsSeller(person))
                    {
                        Console.WriteLine($"{person} is a mango seller!");
                    }
                    else
                    {
                        items = graph.Tops[person];
                        foreach (var item in items)
                        {
                            searchDeq.AddLast(item);
                        }
                        searched.Add(person);
                    }
                }
            }
        }

        private static bool PersonIsSeller(string name){
            return name.LastIndexOf('m') != -1;
        }
        #endregion
    
        #region Алгоритм Дейкстры
        private static void DijkstraAlgorithm(){
            // Граф со стоимостями узлов
            GraphWithCost<string, List<GraphItemWithCost<string, double>>, double> graphWithCost = new GraphWithCost<string, List<GraphItemWithCost<string, double>>, double>();
            graphWithCost.AddTop("start", new List<GraphItemWithCost<string, double>>(){ 
                new GraphItemWithCost<string, double>("a", 6),
                new GraphItemWithCost<string, double>("b", 2),
            });
            graphWithCost.AddTop("a", new List<GraphItemWithCost<string, double>>(){ 
                new GraphItemWithCost<string, double>("fin", 1)
            });
            graphWithCost.AddTop("b", new List<GraphItemWithCost<string, double>>(){ 
                new GraphItemWithCost<string, double>("a", 3),
                new GraphItemWithCost<string, double>("fin", 5),
            });
            graphWithCost.AddTop("fin", new List<GraphItemWithCost<string, double>>(){  });

            Dictionary<string, double> nodesCosts = new Dictionary<string, double>();
            nodesCosts.Add("a", 6);
            nodesCosts.Add("b", 2);
            nodesCosts.Add("fin", double.PositiveInfinity);

            Dictionary<string, string> parents = new Dictionary<string, string>();
            parents.Add("a", "start");
            parents.Add("b", "start");
            parents.Add("fin", " ");

            List<GraphItemWithCost<string, double>> processed = new List<GraphItemWithCost<string, double>>();

            // Найти узел с наименьшей стоимостью среди необработанных
            var node = FindLowestCostNode(nodesCosts, processed);
            // Пробегаем по всем узлам
            while (node.Key != null)
            {
                var cost = nodesCosts[node.Key];
                var neighbors = graphWithCost.Tops[node.Key];
                // Перебрать всех соседей текущего узла
                foreach (var item in neighbors)
                {
                    double newCost = cost + item.Cost;
                    var tmp = nodesCosts.Select(t => t).Where(x => x.Key == item.Top).First();
                    // Если к соседу можно быстрее добраться через текущий узел ...
                    if (tmp.Value > newCost)
                    {
                        // ... обновить стоимость для этого узла
                        nodesCosts[item.Top] = newCost;
                        // Этот узел становится новым родителем для соседа 
                        parents[item.Top] = node.Key;
                    }
                }
                // Узел помечается как обработанный
                processed.Add(new GraphItemWithCost<string, double>(node.Key, node.Value));
                // Найти следующий узел для обработки и повторить цикл
                node = FindLowestCostNode(nodesCosts, processed);
            }

            foreach (var item in parents)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

        private static KeyValuePair<string, double> FindLowestCostNode(Dictionary<string, double> nodesCosts, List<GraphItemWithCost<string, double>> processed)
        {
            double lowestCost = double.PositiveInfinity;
            KeyValuePair<string, double> lowestCostNode = new KeyValuePair<string, double>();
            foreach (var item in nodesCosts)
            {
                double cost = nodesCosts[item.Key];
                if (cost < lowestCost && !processed.Any(t => t.Top == item.Key))
                {
                    lowestCost = cost;
                    lowestCostNode = item;
                }
            }
            return lowestCostNode;
        }
        #endregion
    }
}
