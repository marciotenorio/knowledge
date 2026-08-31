#include <bits/stdc++.h>

using namespace std;

vector<bool> used(256, false);

void bt(string n) {
  if (n.length() == 3) {
    cout << n << endl;
    return;
  }

  for (char i = 'a'; i < 'd'; i++) {
    if (!used[i]) {
      used[i] = true;
      bt(n + i);
      used[i] = false;
    }
  }
}

int main(int argc, char *argv[]) {

  bt("");
  return 0;
}
