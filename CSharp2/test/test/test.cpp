// test.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <stdio.h>
#include <stdlib.h>

#define MAX 100

#define initial 1
#define burning 2
#define burned 3

float current_burn_speed;
float max_burn_speed;
int n;
float neighbour_matrix[MAX][MAX] = { 0 };
float temp_matrix[MAX][MAX] = { 0 };
int state[MAX];
void create_graph();
void BF_Traversal();
void BFS(int v);
void sum_burning_edges(int begining_vertex);
void copy_matrix();

int queue[MAX], front = -1, rear = -1;
void insert_queue(int vertex);
int delete_queue();
int isEmpty_queue();

int main()
{
	create_graph();
	BF_Traversal();
	return 0;
}

void BF_Traversal()
{
	int v;

	for (v = 0; v<n; v++)
		state[v] = initial;

	printf("Enter Start Vertex for BFS: ");
	scanf_s("%d", &v);
	copy_matrix();
	BFS(v);
	printf("\n\nBurning time : %f\n", current_burn_speed);
}

void BFS(int v)
{
	int i;
	insert_queue(v);
	state[v] = burning;

	while (!isEmpty_queue())
	{
		v = delete_queue();
		printf("%d ", v);
		printf("\nBurning time : %f\n", current_burn_speed);
		state[v] = burned;

		for (i = 0; i<n; i++)
		{
			if (temp_matrix[v][i] != 0 && state[i] == initial)
			{
				insert_queue(i);
				state[i] = burning;
			}
		}
		sum_burning_edges(v);
	}
	printf("\n");
}

void sum_burning_edges(int begining_vertex) {
	int index, count_burning_vertex = 0, min_index_vertex_burning_time = 0;
	float min_burning_time = 32767;
	int burning_vertex[MAX];
	for (index = 0; index < n; index++) {
		if (state[index] == burning) {
			burning_vertex[count_burning_vertex++] = index;
		}
	}
	if (count_burning_vertex == 0) {
		return;
	}
	else
		if (count_burning_vertex == 1) {
			current_burn_speed += temp_matrix[begining_vertex][burning_vertex[0]];
		}
		else {
			//insert_queue(begining_vertex);
			state[begining_vertex] = burning;
			for (index = 0; index < count_burning_vertex; index++) {
				if (temp_matrix[begining_vertex][burning_vertex[index]] < min_burning_time) {
					min_burning_time = temp_matrix[begining_vertex][burning_vertex[index]];
					min_index_vertex_burning_time = index;
				}
			}
			current_burn_speed += temp_matrix[begining_vertex][burning_vertex[min_index_vertex_burning_time]];
			for (index = 0; index < count_burning_vertex; index++) {
				if (index != min_index_vertex_burning_time) {
					temp_matrix[begining_vertex][burning_vertex[index]] -= min_burning_time;
					temp_matrix[burning_vertex[index]][begining_vertex] -= min_burning_time;
				}
			}
		}
}

void insert_queue(int vertex)
{
	if (rear == MAX - 1)
		printf("Queue Overflow\n");
	else
	{
		if (front == -1)
			front = 0;
		rear = rear + 1;
		queue[rear] = vertex;
	}
}

int isEmpty_queue()
{
	if (front == -1 || front > rear)
		return 1;
	else
		return 0;
}

int delete_queue()
{
	int delete_item;
	if (front == -1 || front > rear)
	{
		printf("Queue Underflow\n");
		exit(1);
	}

	delete_item = queue[front];
	front = front + 1;
	return delete_item;
}

void create_graph()
{
	int count, origin, destin, count_edges;
	float speedBurn = 0;

	printf("Enter number of vertices : ");
	scanf_s("%d", &n);
	printf("Enter number of edges : ");
	scanf_s("%d", &count_edges);

	for (count = 1; count <= count_edges; count++)
	{
		printf("Enter edge %d : ", count);
		scanf_s("%d %d", &origin, &destin);
		printf("Enter t : ");
		scanf_s("%f", &speedBurn);

		if (origin >= n || destin >= n || origin<0 || destin<0)
		{
			printf("Invalid edge!\n");
			count--;
		}
		else
		{
			neighbour_matrix[origin][destin] = speedBurn;
			neighbour_matrix[destin][origin] = speedBurn;
		}
	}
}

void copy_matrix() {
	int index, i;

	for (index = 0; index < MAX; index++) {
		for (i = 0; i < MAX; i++) {
			temp_matrix[index][i] = neighbour_matrix[index][i];
		}
	}
}


