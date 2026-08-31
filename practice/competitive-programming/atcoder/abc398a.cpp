#include <bits/stdc++.h>

using namespace std;

int main() {
    int size;
    cin>>size;

    if(size == 1) {
        cout<< "=" <<endl;
        return 0;
    } 
    if(size == 2) {
        cout<< "==" <<endl;
        return 0;
    } 

    string ans = "";
    int eqc = 0; eqc = size % 2 == 0 ?  2 : 1; 
    int mid = size / 2;

    if(eqc == 1) {
        for(int i=0; i<size; ++i) {
            if(i == mid) ans = ans + "=";
            else ans = ans + "-";     
        }
    }
    else {
        for(int i=0; i<size; ++i) {
            if(i == mid) {
                ans[i-1] = '=';
                ans = ans + "=";
            }
            else ans = ans + "-";     
        }
    }

    cout << ans << endl;
}