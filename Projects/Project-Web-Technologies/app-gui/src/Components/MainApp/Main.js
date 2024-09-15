//import componente dupa tip-ul userului
import USER_TST from "./ComponentsByType/TST";
import USER_MP from "./ComponentsByType/MP";
import "./Main.css";
//iau starea redux
import { useSelector, shallowEqual, useDispatch } from "react-redux";
import * as actions from "./../../States/Actions";

//date din store
const typeSelector = (state) => state.main.type;

function Main() {
  //iau token si type din store
  const type = useSelector(typeSelector, shallowEqual);

  const dispatch = useDispatch();
  //setam starea globala la login
  const back = (evt) => {
    dispatch(actions.mainActions.go_login());
  };

  //alege ce pot vedea dupa tipul de user
  function chooseDisplayByType(type) {
    if (type === "MP") {
      return <USER_MP></USER_MP>;
    }
    if (type === "TST") {
      return <USER_TST></USER_TST>;
    }
  }

  return (
    <>
      <input
        type="button"
        value="Log out"
        onClick={back}
        id="btnLogOut"
      ></input>

      <div>{chooseDisplayByType(type)}</div>
    </>
  );
}

export default Main;
