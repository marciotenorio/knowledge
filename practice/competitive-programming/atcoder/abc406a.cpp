#include <bits/stdc++.h>

using namespace std;
typedef long long ll;
    
int main() {
    //to get the all permutations: sort the vector and then keep call next_permutation
    ios_base::sync_with_stdio(0);
    cin.tie(0);

    int a, b, c, d;
    cin >> a >> b >> c >> d;

    if(c < a) {
        cout << "Yes" << endl;
    }
    else if(c == a) {
        if(d <= b) {
            cout << "Yes" <<endl;
        }
        else {
            cout << "No" << endl;
        }
    }
    else {
        cout << "No" << endl;
    }
}