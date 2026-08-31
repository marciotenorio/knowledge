#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);

    int n;
    string in;
    cin >> n;

    map<string, int> db;

    for (size_t i = 0; i < n; i++)
    {
        cin >> in;
        auto res = db[in];

        if (res == 0)
        {
            db[in] = 1;
            cout << "OK" << endl;
        }
        else
        {
            string ins = in + to_string(res);
            db.insert({ins, 1});
            db[in] = ++db[in];
            cout << ins << endl;
        }
    }
}