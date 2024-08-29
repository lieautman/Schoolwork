import React,{useState, useEffect, useRef} from 'react';

const App=()=> {
  //1
  const [steps, setSteps]=useState(0);
  //1-t
  const [clicked,setClicked]=useState(0);

  //2
  const [count,setCount]=useState(0);
  //folositor pt lv 2 calculations
  useEffect(()=>{
    document.title = `You clicked ${count} times`;
  });
  //2-t
  const [initial,setInitial] = useState(-1);
  const [modified,setModified] = useState(-1);

  const external = useRef(null);
  //component mounter
  useEffect(()=>{
    setInitial(count)
  },[]);
  //component updated
  useEffect(()=>{
    setModified(count)
  },[count])

  useEffect(()=>{
    //component mounter
    //component updated

    let modificant = document.querySelector('#modificantul');
    let modificat = document.querySelector('#modificatul');
    modificant.style.backgroundColor = 'green';
    //modificat.style.backgroundColor = 'yellow';

    //nu merge pt ca elem din pagina nu pot fi accesate asa
    modificant.addEventListener('load',()=>{
      modificat.style.backgroundColor = 'red';
    })
    //treb accesate prin useRef
    external.current.innerHTML='something';


  },[]);
  //3

  return (
    <>
      <div className='containder1'>
          <p>Today you've taken {steps} steps</p>
          <button onClick={()=>setSteps(steps+1)}>Click me!</button>
      </div>
      <div className='containder1-t'>
          <div id='recttri' onClick={()=>{
            if(clicked){
              setClicked(0)
              let obiect = document.querySelector('#recttri');
              obiect.style.backgroundColor = 'red';
              obiect.style.padding = '100px';
            }
            else{
              setClicked(1)
              let obiect = document.querySelector('#recttri');
              obiect.style.backgroundColor = 'blue';
              obiect.style.padding = '100px';
            }
          }}>Click me to see red or blue!</div>
      </div>
      <div className='containder2'>
          <p>Today you've clicked {count} times</p>
          <button onClick={()=>setCount(count+1)}>Click me!</button>
      </div>
      <div className='containder2-t'>
          <div id='modificantul'>Acesta s-a desenat si treb modif al doilea!</div>
          <div id='modificatul'>Modificat la prima desenare a componentei</div>
          <div ref={external}></div>
          <div>{initial}{modified}</div>
      </div>
      <div className='containder3'>

      </div>
    </>
  );
}

export default App;