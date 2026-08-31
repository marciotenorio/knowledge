#include <bits/stdc++.h>

using namespace std;

typedef long long ll; 

int main()
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);

    int n, m;
    cin >> n >> m;
   
    int in;
    int opin;
    map<int, int> ma;
    for (size_t i = 0; i < n; i++)
    {
       cin >> in;
        
       for (size_t j = 0; j < in; j++)
       {
            cin >> opin;
            ma[opin] = ++ma[opin];
       }
    }

    int ans = 0;
    for (auto i : ma)
    {
       if(i.second == n)
        ans += 1;
    }

    cout << ans << endl;
    
}
    


