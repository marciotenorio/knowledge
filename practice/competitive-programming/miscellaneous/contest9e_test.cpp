#include <bits/stdc++.h>

using namespace std;

vector<int> bfs(int src, const vector<vector<int>> adj) {
    int n = adj.size();
    vector<int> dist(n, -1);
    queue<int> q;

    dist[src] = 0;
    q.push(src);

    while (!q.empty()) {
        int curr = q.front(); q.pop();

        for (int v: adj[curr]) {
            if (dist[v] == -1) {
                dist[v] = dist[curr] + 1;
                q.push(v);
            }
        }
    }

    return dist;
}

int main(){
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int n1, n2, m;
    cin >> n1 >> n2 >> m;
    int n = n1 + n2;

    vector<vector<int>> adj(n);
    for (int i = 0; i < m; i++) {
        int a, b;
        cin >> a >> b;
        --a; --b;
        adj[a].push_back(b);
        adj[b].push_back(a);
    }

    vector<int> dist1 = bfs(0, adj);
    vector<int> dist2 = bfs(n - 1, adj);

    int max1 = 0, max2 = 0;

    for (int i = 0; i < n1; i++)
        max1 = max(max1, dist1[i]);

    for (int i = n1; i < n; i++)
        max2 = max(max2, dist2[i]);

    int ans = max1 + 1 + max2;
    cout << ans << endl;

    return 0;
}
