#include <bits/stdc++.h>

using namespace std;

typedef long long ll; 

map<pair<int,int>, int> costs;

int rec(vector<int> stones, int i, int k) {
    if(i == stones.size())
        return 0;

    int low = stones[i];
    for(int j=i+1; j<i+k && j<stones.size(); ++j) {
        if(costs.find(make_pair(i,j)) != costs.end())
            low = costs[make_pair(i,j)];

        low = abs(stones[i] - rec(stones, i+i, k));

        pair key = make_pair(i,j);
        if(costs.find(key) == costs.end()){
            costs[key] = abs(stones[i] - stones[j]);
        }

        rec(stones, i+1, k);

        return costs[key];
    }
    
}

int main()
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);

    // tamanho do vector N e o tamanho maximo do pulo K
    // 10 30 40 50 80 10 
    // i=10; i -> 30, i->40, i->50  

    int n, k;
    cin >> n >> k;

    vector<int> stones(n);

    rec(stones, 0, k);
}
    


