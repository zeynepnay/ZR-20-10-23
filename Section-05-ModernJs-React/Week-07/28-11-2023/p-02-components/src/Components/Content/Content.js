import ProductContainer from "../ProductContainer/ProductContainer";
import "./Content.css";

import React from 'react'

function Content() {
  return (
    <>
        <h1 className="Title">Hoşgeldiniz</h1>
        <div className="Text-Container">
              <p className="Text">Lorem ipusm akakdkadadad sdsadasdada scascdasdcasc scscafscas</p>
        </div>
        <button className="Btn-Detail "type="button">Detay</button>
        <ProductContainer/>
    </>
  )
}

export default Content


















// import React, { Component } from 'react'

// export class Content extends Component {
//   render() {
//     return (
//       <div>Content</div>
//     )
//   }
// }

// export default Content