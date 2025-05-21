#include <iostream>
#include "ll.h"

using namespace std;

linked_list* create(int val) {
    linked_list* ll = (linked_list*) malloc(sizeof(ll));
    ll->size = 1;
    
    node* n = (node*) malloc(sizeof(node));
    n->val = val;
    n->next = NULL;

    ll->first = n;
    ll->last = n;

    return ll;
}

void push_back(linked_list* ll, int val) {
    node* n = (node*) malloc(sizeof(node));
    n->val = val;

    ll->last->next = n;
    ll->last = n;
    ll->size++;
}

void push_front(linked_list* ll, int val) {
    node* n = (node*) malloc(sizeof(node));
    n->val = val;

    ll->first->next = n;
    ll->first = n;
    ll->size++;
}

node* get(linked_list* ll, int val) {
    if(ll->first == NULL || ll->size == 0)
        return NULL;

    node* tmp = ll->first;
    while(true) {
       if(tmp == NULL) return NULL;
       if(tmp->val == val) return tmp;
       tmp = tmp->next;
    }
}

bool find(linked_list* ll, int val) {
    node* result = get(ll, val);
    return result != NULL;
}

void print(linked_list* ll) {
    if(ll == NULL || ll->first == NULL || ll->first == NULL)
        return;

    node* tmp = ll->first;
    while(true) {
        if(tmp == NULL)
            return;

       cout << tmp->val << endl;
       tmp = tmp->next; 
    }
    
}

void free_linked_list(linked_list* ll) {
    
}