#include <iostream>
#include <vector>

using namespace std;

long long dfs(int i, int j, int n, int m, vector<vector<int>> &grid, vector<vector<bool>> &visited){
    if (i < 0 || i >= n || j < 0 || j >= m || grid[i][j] == 0 || visited[i][j]) {
        return 0;
    }

    visited[i][j] = true;

    long long currentLakeVolume = grid[i][j];

    currentLakeVolume += dfs(i + 1, j, n, m, grid, visited);
    currentLakeVolume += dfs(i - 1, j, n, m, grid, visited);
    currentLakeVolume += dfs(i, j + 1, n, m, grid, visited);
    currentLakeVolume += dfs(i, j - 1, n, m, grid, visited); 

    return currentLakeVolume;
}

int main() {
    int t, n, m;

    cin >> t;
    vector<long long> largestLakes;
    for (int i = 0; i < t; i++)
    {  
        cin >> n >> m;
        vector<vector<int>> matrix(n, vector<int> (m, 0));
        vector<vector<bool>> visited(n, vector<bool> (m,false));
        long long largestLake = 0;

        for(int j = 0; j < n; j++){
            for( int k = 0; k < m; k++){
                cin >> matrix[j][k];
            }
        }

        for(int j = 0; j < n; j++){
            for(int k = 0; k < m; k++){
                if(matrix[j][k] > 0 && !visited[j][k]){
                    largestLake = max(largestLake, dfs(j, k, n, m, matrix, visited));
                }
            }
        }
        largestLakes.push_back(largestLake);
    }
    
    for(int i = 0; i < largestLakes.size(); i++){
        cout << largestLakes[i] << endl;
    }
    return 0;
}