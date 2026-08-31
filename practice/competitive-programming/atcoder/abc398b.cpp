#include <bits/stdc++.h>

using namespace std;

int main() {
    map<int, int> map; 
    int input;
    for(int i=0; i<7; ++i) {
        cin>>input;
        
        auto it = map.find(input);
        if(it != map.end()) {
            auto v = map[input];
            ++v;
            map[input] = v;
        }
        else {
            map.insert({input, 1});
        }
    }
    
    int fh1 = 0;
    int fh2 = 0;
    for(auto x : map) {
        if(x.second >= 3) {
            ++fh1;
        }
        else if(x.second >= 2) {
            ++fh2;
        }
    }

    string ans = (fh1 > 0 && fh2 > 0) || (fh1 > 1) ? "Yes" : "No";
    cout << ans << endl;
}