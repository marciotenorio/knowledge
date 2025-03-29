#include <bits/stdc++.h>
using namespace std;

int main() {
    int r = 1, s = 0;
    cin>> s;
    vector<int> ar;
    for(int i=0; i<s; ++i) {
        int input;
        cin>> input;
        ar.push_back(input);
    }
    vector<int> ans = ar;
    int maxI = 0;
    vector<int> eqp;

    int done = 0;
    while(done != ar.size()) {

        for(int k=0; k<ar.size(); ++k) {
            if(ar[k] > ar[maxI]) maxI = k;
        }                                     

        for(int j=0; j<ar.size(); ++j) {
            if(ar[j] == ar[maxI]) eqp.push_back(j);
        }

        int k = eqp.size();
        for(int p=0; p<eqp.size(); ++p) {
            ans[eqp[p]] = r;
            ar[eqp[p]] = -1;
            ++done;
        }

        r += k;
        maxI = 0;
        eqp.clear();
    }

    for(int i=0; i<ans.size(); ++i) cout << ans[i] << endl;
}