
#ifndef H__LL
#define H__LL

/**
 * Node to a int type.
 */
typedef struct node {
    int val;
    struct node* next;
} node;

/**
 * LinkedList to integer type.
 */
typedef struct linked_list {
    int size;
    struct node* first;
    struct node* last;
} linked_list; 

/**
 * A wrapper to implement stack behavior.
 */
typedef linked_list stack;

/**
 * Create a newn Linked List.
 */
linked_list* create(int val);

/**
 * Inserts at the end of Linked List.
 */
void push_back(linked_list* ll, int val);

/**
 * Inserts in the front of Linked List.
 */
void push_front(linked_list* ll, int val);

/*
 * Get a pointer to node with val value
 * in this Linked List.
 */
node* get(linked_list* ll, int val);

/**
 * Verify if Linked List contains that value.
 */
bool find(linked_list* ll, int val);

/**
 * Print in STDOUT the values from Linked List.
 */
void print(linked_list* ll);

void free_linked_list(linked_list* ll);

stack* create(int val);

#endif