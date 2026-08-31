#include <bits/stdc++.h>
using namespace std;

// struct cmp {
//     bool operator() (pair<int,int> a, pair<int,int> b) const {
//         return a.first == b.first && a.second == b.second;  
//     };
// };

int main() {
    ios_base::sync_with_stdio(0);
    cin.tie(0);

    string in;
    int s;
    cin >> s;
    cin >> in;

    auto curr = make_pair<int,int>(0, 0);
    set<pair<int, int>> moves;
    auto fm = pair<int,int>(curr);
    moves.insert(fm);

    for(int i=0; i < s; ++i) {
        if(in[i] == 'R') {
            ++curr.first;
        }
        if(in[i] == 'L') {
            --curr.first;
        }
        if(in[i] == 'U') {
            ++curr.second;
        }
        if(in[i] == 'D') {
            --curr.second;
        }

        auto result = moves.find(curr);
        if(result != moves.end()) {
            cout << "Yes" << endl;
            return 0;
        } 
        else {
            auto r = pair<int,int>(curr);
            moves.insert(r);
        }     
    }

    cout << "No" << endl;
}