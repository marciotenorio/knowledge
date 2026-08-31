#include <bits/stdc++.h>
#include <climits>

using namespace std;
typedef long long ll;

void bf(vector<vector<pair<int, int>>> adj, int n) {
  vector<int> pre(n, -1);
  vector<int> dist(n, INT_MAX);

  for (int i = 0; i < n - 1; i++) {
    for (int j = 0; j < n; j++) {
      for (auto u : adj[j]) {
        int k = u.first;
        int peso = u.second;

        if (dist[j] + peso < dist[k]) {
          dist[k] = dist[j] + peso;
          pre[k] = j;
        }
      }
    }
  }
}

int main(int argc, char *argv[]) {
  ios_base::sync_with_stdio(false);
  cin.tie(nullptr);

  return 0;
}
