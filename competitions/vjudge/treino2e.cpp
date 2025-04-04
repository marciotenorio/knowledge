#include <bits/stdc++.h>
using namespace std;

// struct cmp {
//     bool operator() (pair<int,int> a, pair<int,int> b) const {
//         return a.first == b.first && a.second == b.second;
//     };
// };

int main()
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);

    long long in;
    int n;
    cin >> n;

    long long x;
    cin >> x;
    multiset<long long> mult;

    for (size_t i = 0; i < n; i++)
    {
        //x = a_i - in => a_i = x + in || *-1 
        cin >> in;
        long long neg = -(x) + in;
        long long pos = x + in;

        if(0 == x) {
            cout << "Yes" << endl;
            return 0;
        }

        auto rpos = mult.find(pos);
        auto rneg = mult.find(neg);

        if((rpos != mult.end() && (x == (*rpos - (in)))
            || (rneg != mult.end() && (x == in - *rneg)))) {
            cout << "Yes" << endl;
            return 0;
        } 

        mult.insert(in);
    }

    cout << "No" << endl;
}