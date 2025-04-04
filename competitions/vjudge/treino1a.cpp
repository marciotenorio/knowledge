#include <bits/stdc++.h>
using namespace std;

int main() {
    int p;
    cin>> p;
    
    if(p == 1) {
        cout << 0 << endl;
        return 0;
    }

    int max = 0;
    int maxpc = 0;
    int in;
    vector<int> v;
    for (size_t i = 0; i < p; i++)
    {
        cin >> in;
        v.push_back(in);
        if(in > v[max]) max = i;
    }

    for(int i=0; i<v.size(); ++i) if(v[i] == v[max]) ++maxpc;
    
    int ans;
    if(max == 0) ans = maxpc > 1 ? 1 : 0;
    else ans = v[max] - v[0] + 1;

    cout << ans << endl;
}