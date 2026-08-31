#include <bits/stdc++.h>

using namespace std;

typedef long long ll; 

int main()
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);

    string s;
    cin >> s;
    
    vector<char> l;
    string res;
    for (size_t i = 0; i < s.length(); i++)
    {
        l.push_back(s[i]);
    }
    
    sort(l.begin(), l.end());
    res.append(string(l.begin(), l.end())).append("\n");

    int count = 1;
    while(true) {
        auto flag = next_permutation(l.begin(), l.end());

        if(!flag) break;

        res.append(string(l.begin(), l.end())).append("\n");
        ++count;
    }
    
    cout << count << endl;
    cout << res << endl;
    
}
    


