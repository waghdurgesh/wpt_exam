import { List } from "./components/List";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
import { Details } from "./components/Details";
const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/training/getlist',
    element: <List />
  },
  {
    path: '/fetch-data',
    element: <FetchData />
  },
  {
    path: '/training/details/:id',
    element: <Details />
  }
];

export default AppRoutes;
