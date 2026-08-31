#include <bits/stdc++.h>
using namespace std;

int main() {
    ios_base::sync_with_stdio(0);
    std::cin.tie(0);

    int a, b, c, in;
    std::cin >> a;
    
    int va[a];
    for (size_t i = 0; i < a; i++)
    {
        std::cin >> in;
        va[i] = in;
    }

    
    std::cin >> b;
    int vb[b];
    for (size_t i = 0; i < b; i++)
    {
        std::cin >> in;
        vb[i] = in;
    }
   
    std::cin >> c;
    int vc[c];
    for (size_t i = 0; i < c; i++)
    {
        std::cin >> in;
        vc[i] = in;
    }

    int x;
    std::cin >> x;
    int vx[x];
    for (size_t i = 0; i < x; i++)
    {
        std::cin >> in;
        vx[i] = in;
    }

    set<int> sum;
    for (size_t i = 0; i < a; i++)
    {
        for (size_t j = 0; j < b; j++)
        {
            for (size_t k = 0; k < c; k++)
            {
                sum.insert(va[i] + vb[j] + vc[k]);
            }
            
        }
        
    }
    
    
    for (size_t i = 0; i < x; i++)
    {
        auto r = sum.find(vx[i]);
        if(r != sum.end()) cout << "Yes" << endl;
        else cout << "No" << endl;
    }
}