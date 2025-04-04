#include <bits/stdc++.h>
using namespace std;

int main() {
    ios_base::sync_with_stdio(0);
    cin.tie(0);

    set<string> s;
    int in;
    string w; 
    cin>> in;

    for (size_t i = 0; i < in; i++)
    {
        cin>> w;
        s.insert(w);
    }

    cout << s.size() << endl;
}