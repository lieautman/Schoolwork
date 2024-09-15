import { SERVER_GLOBAL } from "../../Configs/globals";
const SERVER = SERVER_GLOBAL + "/bug";

export const GET_BUGS = "GET_BUGS";
export const GET_PERSONAL_BUGS = "GET_PERSONAL_BUGS";
export const CREATE_BUG = "CREATE_BUG";
export const DELETE_BUG = "DELETE_BUG";
export const UPDATE_BUG = "UPDATE_BUG";
export const SOLVE_BUG = "SOLVE_BUG";

export function getBugs() {
  return {
    type: GET_BUGS,
    payload: async () => {
      const response = await fetch(`${SERVER}/all`);
      const data = await response.json();
      return data.bugs;
    },
  };
}
export function getPersonalBugs(type, token) {
  return {
    type: GET_PERSONAL_BUGS,
    payload: async () => {
      const response = await fetch(`${SERVER}/${type}/all`, {
        method: "post",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({ token: token }),
      });
      const data = await response.json();
      return data.bugs;
    },
  };
}
export function createBug(
  severity,
  priority,
  description,
  idOfTester,
  idOfProject,
  type,
  token
) {
  return {
    type: CREATE_BUG,
    payload: async () => {
      let response = await fetch(`${SERVER}/${type}/create`, {
        method: "post",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          severity: severity,
          priority: priority,
          description: description,
          idOfTester: idOfTester,
          idOfProject: idOfProject,
          token: token,
        }),
      });
      let data = { all: [], personal: [], message: "" };
      data.message = await response.json();
      response = await fetch(`${SERVER}/all`);
      data.all = await response.json();
      response = await fetch(`${SERVER}/${type}/all`, {
        method: "post",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({ token: token }),
      });
      data.personal = await response.json();
      return data;
    },
  };
}
export function deleteBug(id, type, token) {
  return {
    type: DELETE_BUG,
    payload: async () => {
      let response = await fetch(`${SERVER}/${type}/delete/${id}`, {
        method: "delete",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({ token: token }),
      });
      let data = { all: [], personal: [] };
      response = await fetch(`${SERVER}/all`);
      data.all = await response.json();
      response = await fetch(`${SERVER}/${type}/all`, {
        method: "post",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({ token: token }),
      });
      data.personal = await response.json();
      return data;
    },
  };
}
export function updateBug(
  id,
  severity,
  priority,
  description,
  link,
  idOfTester,
  idOfProject,
  type,
  token
) {
  return {
    type: UPDATE_BUG,
    payload: async () => {
      let response = await fetch(`${SERVER}/${type}/update/${id}`, {
        method: "put",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          severity: severity,
          priority: priority,
          description: description,
          link: link,
          idOfTester: idOfTester,
          idOfProject: idOfProject,
          token: token,
        }),
      });
      let data = { all: [], personal: [] };
      response = await fetch(`${SERVER}/all`);
      data.all = await response.json();
      response = await fetch(`${SERVER}/${type}/all`, {
        method: "post",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({ token: token }),
      });
      data.personal = await response.json();
      return data;
    },
  };
}

//solve pt MP
export function updateSolve(bugId, link) {
  return {
    type: SOLVE_BUG,
    payload: async () => {
      let response = await fetch(`${SERVER}/updateSolve/${bugId}`, {
        method: "put",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({ link: link }),
      });
      response = await fetch(`${SERVER}/all`);
      const data = await response.json();
      return data;
    },
  };
}
