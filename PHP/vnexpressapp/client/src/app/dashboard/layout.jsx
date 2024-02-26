import NavBarReponsive from "@/components/NavBarReponsive";
import Sidebar from "@/components/Sidebar";

export const metadata = {
  title: "Dashboard",
  description: "Dashboard",
};

export default function DashBoardLayout({ children }) {
  return (
    <div>
      <Sidebar />
      <div className="p-4 sm:ml-64">
        <div className="p-4 border-2 border-gray-200 border-dashed rounded-lg dark:border-gray-700 mt-14">
          {children}
        </div>
      </div>
    </div>
  );
}
