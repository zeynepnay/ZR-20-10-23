import React, { useState } from 'react'
import TodoForm from './TodoForm';
import { v4 as uuidv4 } from 'uuid';
import Todo from './Todo';
import TodoContainer from './TodoContainer';
import { faL } from '@fortawesome/free-solid-svg-icons';

const TodoWrapper = () => {
    let [todos, setTodos] = useState([]);

    const addTodo = todo => {
        setTodos([...todos, {
            id: uuidv4(),
            desc: todo,
            completed: false,
            isEditing: false
        }]);
    };

    const toggleComplete = (id) => {

        setTodos(
            todos.map((todo) => todo.id == id ? { ...todo, completed: !todo.completed } : todo));
    };


    const deleteTask = (id) => setTodos(todos.filter((todo) => todo.id != id));

    const editTodo = (id) => {
        setTodos(
            todos.map((todo) => {
                return todo.id == id ? { ...todo, isEditing: !todo.isEditing } : todo
            })
        );
    };

    const saveTodo = (id, value) => {
        setTodos(
            todos.map((todo) =>
                todo.id == id ? { ...todo, desc: value ,isEditing: !todo.isEditing} : todo
            )
        );

    };


    return (
        <>
            <div className='TodoWrapper'>
                <h1>FS-2310-13 Todo App</h1>
                <TodoForm addTodo={addTodo} todos={todos} />
                <TodoContainer
                    todos={todos}
                    toggleComplete={toggleComplete}
                    deleteTask={deleteTask}
                    editTodo={editTodo}
                    saveTodo={saveTodo}
                />
            </div>
        </>
    )
}

export default TodoWrapper;