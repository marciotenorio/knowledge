#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);

    int n, m;
    cin >> n >> m;
    string plates[n];

    for (size_t i = 0; i < n; i++)
    {
        cin >> plates[i];
    }

    map<string, int> prices;
    string plate;
    for (size_t i = 0; i < m; i++)
    {
       cin >> plate; 
       prices.insert({plate, 0});
    }
   
    int price;
    long defaultValue = 0;
    long total = 0;
    cin >> defaultValue; 
    for (auto &i : prices)
    {
       cin >> price;
       i.second =  price;
    }
    
    for (auto i : plates)
    {
       auto r = prices.find(i);
       if(r != prices.end()) {
        total += r->second;
       }
       else {
        total += defaultValue;
       }
    }

    cout << total << endl;
    
}