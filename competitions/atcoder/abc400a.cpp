#include <bits/stdc++.h>

using namespace std;

typedef long long ll; 

int main()
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);

    int a;
    cin >> a;

    int r = 400 % a;

    if(r == 0) {
        cout << 400/a << endl;
    }
    else cout << -1 << endl;
}