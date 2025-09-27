#include <bits/stdc++.h>

using namespace std;

typedef long long ll; 

int main()
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);

    string s;
    cin >> s;

    bool up = false;
    bool lo = false;

    set<char> letters;
    for (int i = 0; i < s.length(); i++)
    {
        if(islower(s[i])) lo = true;
        if(isupper(s[i])) up = true;
        letters.insert(s[i]);
    }
    
    if(up && lo && letters.size() == s.length())
        cout << "Yes" << endl;
    else
        cout << "No" << endl;
}
    


