#include <bits/stdc++.h>
using namespace std;

int main() {

    string a, b;
    int s;
    cin >> s >> a >> b;

    int c = 0;
    for(int i=0; i<s; ++i) {
        if(a[i] != b[i]) c++;
    }

    cout << c << endl;
}