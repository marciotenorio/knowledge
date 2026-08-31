#include <bits/stdc++.h>
using namespace std;

int main() {
    ios_base::sync_with_stdio(0);
    cin.tie(0);

    string a;
    cin>> a;

    vector<int> all = {0,1,2,3,4,5,6,7,8,9};
    for (size_t i = 0; i < 9; i++)
    {
       all[a[i] - '0'] = -1;
    }

    for (size_t i = 0; i < 10; i++)
    {
        if(all[i] != -1) {
            cout << all[i] << endl;
            break;
        }
    }
}