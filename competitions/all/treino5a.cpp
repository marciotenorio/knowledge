#include <bits/stdc++.h>

using namespace std;
typedef long long ll;

int main(int argc, char *argv[]) {
  ios_base::sync_with_stdio(false);
  cin.tie(nullptr);

  int n, m;
  cin >> n >> m;

  vector<priority_queue<int, vector<int>, greater<int>>> adj(n + 1);
  int a, b;
  for (int i = 1; i <= m; i++) {
    cin >> a >> b;
    adj[a].push(b);
    adj[b].push(a);
  }

  for (int i = 1; i <= n; ++i) {
    cout << adj[i].size();
    while (!adj[i].empty()) {
      cout << " " << adj[i].top();
      adj[i].pop();
    }
    cout << endl;
  }

  return 0;
}
