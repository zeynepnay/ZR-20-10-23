import React, { useContext } from 'react'
import { TodoContext } from '../Contexts/TodoContext';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPenToSquare , faTrashCan} from '@fortawesome/free-regular-svg-icons';

const Todo = ({ task }) => {
    const context = useContext(TodoContext);
    return (
        <div>
            <li className={task.isCompleted ? "d-flex justify-content-between align-items-center list-group-item rounded-2 mb-1 text-decoration-line-through text-success"
                : "d-flex justify-content-between align-items-center list-group-item rounded-2 mb-1"}>
                <div role="button" onClick={() => { context.toggleComplete(task.id) }} className='w-75'>{task.desc}</div>
                <div>
                    <button className='btn btn-warning  me-1' onClick={() => { context.toggleEditing(task.id) }}>
                        <FontAwesomeIcon icon={faPenToSquare} className='fs-5'/>
                    </button>
                    <button className='btn btn-danger ' onClick={() => { context.deleteTask(task.id) }}>
                        <FontAwesomeIcon icon={faTrashCan} />
                    </button>
                </div>
            </li>
        </div>
    )
}

export default Todo