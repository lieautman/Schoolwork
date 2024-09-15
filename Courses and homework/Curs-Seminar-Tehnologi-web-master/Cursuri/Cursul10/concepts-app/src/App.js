import PropsParent from './props/PropsParent';
import StateExample from './state/StateExample';

function App() {
  return (
    <>
      <div>
        I will be the app
      </div>
      <StateExample />
      <h2>Props:</h2>
      <PropsParent></PropsParent>
      <h2>Lifting:</h2>
    </>
  );
}
//update not working

export default App;
