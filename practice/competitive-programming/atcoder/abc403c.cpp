#include <bits/stdc++.h>
using namespace std;

typedef long long ll; 

int main()
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);

    ll n, m, q;
    cin >> n >> m >> q;

    map<ll, set<ll>> map;
    ll t,x,y;
    string in;
    getline(cin, in);

    for (size_t i = 0; i < q; i++)
    {
        getline(cin, in);
        stringstream iss(in);

        if(in[0] - '0' == 1) {
            iss>> t >> x >> y;
            map[x].insert(y);
        }

        if(in[0] - '0' == 2) {
            iss>> t >> x;
            map[x].insert(-1);
        }

        if(in[0] - '0' == 3) {
            iss>> t >> x >> y;
            auto f = map[x].count(y) + map[x].count(-1);
            if(f > 0) cout << "Yes" << endl;
            else cout << "No" << endl;
        }
    }
}
    