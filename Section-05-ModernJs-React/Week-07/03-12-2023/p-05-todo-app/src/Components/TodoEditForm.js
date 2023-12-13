import React, { useState } from 'react'

const TodoEditForm = ({ task , saveTodo}) => {
    const [value, setValue] = useState(task.desc);

    const handleSubmit = (e) => {
        e.preventDefault();
        saveTodo(task.id , value);
    }
    return (
        <>
            <form onSubmit={handleSubmit} className='TodoForm'>
                <input
                    type="text"
                    value={value}
                    onChange={
                        (e) => { setValue(e.target.value) }
                    }
                    className='TodoInput'
                    placeholder='Update task'
                />
                <button type='submit' className='TodoBtn btnSave' >Save</button>

            </form>
        </>
    )
}

export default TodoEditForm;