# Algorithms and Data Structures

# Summary

- [. . /Fundamentals](../fundamentals.md)
- [Basics](#basics)
- [Asymptotic Analysis](#asymptotic-analysis)
- [Sorting](#sorting)

# Basics

Some definitions to remember:

- Eficácia | Corretude : Produz a saída esperada em tempo finito? -> qualidade do produz o resultado esperado, atinge objetivos.

- Eficiência | Complexidade : essa é a melhor solução para o caso? -> capacidade de realizar tarefas, produtividade.

- Data, register, memory, bit, byte, word, instruction, algorithm and process.

- Process (Stack, Heap, Code Segment->Machine code and Data Segment->Global and static variables)

- Static allocation -> Compile time || Dynamic Allocation -> Runtime

- Function/Method Stack (Parameters, return and local variables). In the end, all data are erased
from memory.

- Recursive function problem -> Data redundancy in memory.

- All pointers have the same size, 8 bytes (0x00A). Explore about ptr size, content, etc.

- When freeing some pointer, assign null after to prevent access to this content.

- Allocation memory problems: Segmentation fault, memory leak and hard debugging;

- Array -> Uniform data type and sequential || Struct -> not homogeneous data block

- Union -> Em C eles existe e são uma maneira de economizar memória. Se você tem uma struct insumo com dois
campos: double volume e int peso. Você so guarda uma por insumo (liquido volume, outros é peso), então
uma maneira de economizar é usar union pros dois por que ai ele aloca pro maior e quando um for preenchido
o outro não será acessível e vice-versa. Lembrar de resposta do stackoverflow.
- Memoization - expensive functional calls turned into pure functions (no side effects and always same 
output for a given input). You can use a hashmap, for example.
- Análise empirica e análise matemática de algoritmos.

# Asymptotic Analysis

It's a mathematical approach based on limits to define complexity and space of algorithm's.
Asymptotic means "for all enough large values".

## Complexity

Premises:

> The execution time of an algorithm is the: cost to execute one instruction and the number 
> of times of her are executed.
> 
>  "Simple" instruction have constant execution time.
> 
> The dominant term in a polynomial will determine your complexity.

Some notations:

- Big-O: Like O(n), it's an upper limit in the worst case.

![](../../img/big-o.png)

- Ω (Omega): Like Ω(n), it's a lower limit in the worst case.

![](../../img/omega.png)

- Θ (Theta): Like Θ(n), it's between upper and lower limits in the worst case.
  
![](../../img/theta.png)


Example: Binary Search

In a binary search at each step, the search space is divided into two. If you want to find ``10`` in the
array below like this:

> [1,2,4,7,8,10] -> [8,10] -> [10]

At each interaction, we have this kind of behavior:

> 1ª $\frac{n}{2^0}$ $\implies$ 2ª $\frac{n}{2^1}$ $\implies$ 3ª $\frac{n}{2^2}$ ... $\implies$
> nª $\frac{n}{2^{i-1}} = 1$ last step has only one element.
> 
> when n = array size; i = steps.

Resulting in a formula as follows:

> $$\frac{n}{2^{i-1}} = 1$$
> How to know the number of steps (i) based on the array size (n)?

Doing some math:

> $$ \frac{n}{2^{i-1}} = 1 \implies n = 1.2^{i-1} \implies log_2 \space n = log_2 \space 2^{i-1} \implies
log_2 \space n = (i-1) * log_2 \space 2 \implies i = 1 + \log_2 n \  $$

Take care only of the terms that define complexity, we have: $i = \log_2 n$ .


## Space

Basically is based on input size of an algorithms.
Has two major concerns:

- Fixed space - independent of input size
- Not fixed space - dependent of input size

Uses the asymptotic notation as well.
Keep in mind that always have the tradeoff between effience and space usage, so
TYPICALLY more efficence means increase the space usage and less efficence means
decrease of space usage.

# Sorting

Sorting refers to ordering data in an increasing or decreasing manner according to some linear 
relationship among the data items. 
No fim o resultado é uma permutação dos dados de maneira que obedeça uma relação de ordem.

**ordering**: is basically a set of rules that determine what items come before, or after, what other item;\
**sorting**: the proccess that actually arranging the sequence of items.

Formally, the output of any sorting algorithm must satisfy two conditions:

The output is in **monotonic** order (each element is no smaller/larger than the previous element, according to the required order).

The output is a **permutation** (a reordering, yet retaining all of the original elements) of the input.

É a permutação dos elementos a serem classificados

## Stability

Um algoritmo de ordenação é estável (= stable) se não altera a posição relativa dos elementos que 
têm o mesmo valor.  Digamos, por exemplo, que um vetor de números do tipo double é ordenado 
considerando apenas a parte inteira dos números (e ignorando a parte fracionária).  
Se o algoritmo de ordenação for estável, os números que têm a mesma parte inteira continuarão 
na mesma ordem relativa em que estavam originalmente. Na seguinte figura, a primeira linha mostra 
o vetor original e a segunda, o vetor ordenado por um algoritmo estável:

> 44.0	55.1	55.2	33.9	22.9	11.0	22.5	22.6\
> 11.0	22.9	22.5	22.6	33.9	44.0	55.1	55.2


## Algorithms

[Java Implementation here](./java/ds-algo/src/main/java/br/tenorio/algo/Sort.java)

