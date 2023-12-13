
import './App.css'
import TodoWrapper from './Components/TodoWrapper';
import {useId} from 'react';
import {v4 as idGenerate} from 'uuid';

const INITIAL_STATE = [
  { id: idGenerate(), desc: "Ayşe Nuru aramayı unutma", isCompleted: false, isEditing: false },
  { id: idGenerate(), desc: "Sinemaya git", isCompleted: false, isEditing: false },
  { id: idGenerate(), desc: "Feyyaz Yigiti ara", isCompleted: true, isEditing: false },
  { id: idGenerate(), desc: "gibi 5. sezonu izle", isCompleted: false, isEditing: false },
  { id: idGenerate(), desc: "javascript konferansını unutma", isCompleted: false, isEditing: false }
]

function App() {
 
  return (
    <>
      <TodoWrapper tasks={INITIAL_STATE}/>
    </>
  );
}

export default App;
