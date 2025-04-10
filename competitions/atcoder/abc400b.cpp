#include <bits/stdc++.h>

using namespace std;

typedef long long ll; 

int main()
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);

    ll n, m;
    cin >> n >> m;

    ll x = 0;
    for(ll i=0; i<= m; ++i) {
        auto r = (ll)powl(n, i);
        x += r;
    }

    if(x > 1'000'000'000 || x < 0) cout << "inf" << endl;
    else cout << x << endl;
}