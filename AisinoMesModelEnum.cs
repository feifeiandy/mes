using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Aisino.MES.Model
{
    #region 基础信息管理
    /// <summary>
    /// 标签类型
    /// </summary>
    public enum TagType
    {
        _1356 = 1,
        _900 = 2,
        _433 = 3,
        人工录入无标签实体 = 99
    }

    /// <summary>
    /// 标签分类
    /// </summary>
    public enum TagFlag
    {
        员工卡 = 1,
        业务卡 = 2,
        内部车卡 = 3
    }
    /// <summary>
    /// 停用状态
    /// </summary>
    public enum StoppedStatus
    {
        启用 = 1,
        停用 = 0
    }

    /// <summary>
    /// 交易类型
    /// PS:对于交易类单据而言，始终会产生数据增减
    /// </summary>
    //public enum TransType
    //{
    //    库存增量 = 1,
    //    库存扣量 = 2
    //}

    /// <summary>
    /// 编号类型
    /// </summary>
    //public enum BillCodeType
    //{
    //    包装类型 = 1,
    //    运输工具 = 2,
    //    付款方式 = 3,
    //    信用等级 = 4,
    //    付款周期 = 5,
    //    客户类型 = 6
    //}

    /// <summary>
    /// 日志类型
    /// </summary>
    public enum LogType
    {
        消息 = 1,
        错误 = 2
    }

    public enum SiteStatus
    {
        启用 = 1,
        停用 = 0
    }

    public enum TagStatus
    {
        未使用 = 1, 已使用 = 2, 已停用 = 99
    }

    public enum WharfStatus
    {
        可使用 = 1,
        使用中 = 2,
        已停用 = 3
    }

    public enum TaskProcessNode
    {
        默认 = -1,
        初始 = 1,
        报港完成 = 2,
        化验完成 = 3,
        称重完成 = 4,
        结算保存 = 5,
        结算完成 =6,
        退港完成 = 7
    }
    #endregion

    #region 系统管理
    /// <summary>
    /// 部门属性中的类型
    /// </summary>    
    public enum DeparrmentType
    {
        组织机构 = 0,
        下属部门 = 1
    }
    /// <summary>
    /// 操作方法类型
    /// </summary>
    public enum FunctionType
    {
        模块构造方法 = 1,
        操作方法 = 2
    }

    /// <summary>
    /// 菜单类型
    /// </summary>
    public enum MenuType
    {
        模块菜单 = 1,
        操作菜单 = 2,
        显示菜单 = 3
    }

    /// <summary>
    /// 人员信息性别
    /// </summary>
    public enum UserSex
    {
        男 = 1,
        女 = 2
    }

    public enum SysCodeType
    {
        包装类型 = 1,
        运输工具 = 2,
        付款方式 = 3,
        信用等级 = 4,
        付款周期 = 5,
        客户类型 = 6
    }

    public enum OpType
    {
        新增类型 = 0,
        修改类型 = 1
    }

    public enum SysBillState
    {
        启用 = 1,
        停用 = 2
    }

    public enum SysBillCodeType
    {
        仓储交易单据 = 1,
        检化验单据 = 2,
        生产计划单据 = 3,
        称重单据 = 4,
        报港单据 = 5,
        结算单据 = 6,
        合同单据 = 7
    }

    public enum MetroTypes
    {
        Single = 1,
        Double = 2,
        Quadruple = 3
    }

    public enum SysUserType
    {
        可登录用户 = 1,
        普通员工 = 2
    }
    #endregion

    #region 仓储管理
    /// <summary>
    /// 交易类型
    /// 1：入库
    /// 2：出库
    /// </summary>
    public enum InOutType
    {
        入库 = 1,
        出库 = 2,
        调拨 = 3,
        未设置 = 4
    }
    /// <summary>
    /// 仓房状态
    /// </summary>
    public enum WarehouseStatus
    {
        空仓 = 1,
        封仓 = 2,
        作业 = 3
    }
    /// <summary>
    /// 批次管理原则
    /// </summary>
    public enum WarehouseBatchPrinciple
    {
        先入先出 = 1,
        后入先出 = 2
    }

    /// <summary>
    /// 单据状态
    /// </summary>
    public enum WarehouseTransactionMasterStatus
    {
        新建 = 1,
        提交 = 2,
        确认 = 3,
        作废 = 99
    }

    /// <summary>
    /// 执行操作
    /// </summary>
    public enum Operate
    {
        确认 = 1,
        回滚 = 2
    }

    //public enum WarehouseBatchPrinciple
    //{
    //    库存增量 = 1,
    //    库存扣量 = 2
    //}

    public enum DirectionForDataChange
    {
        增加原有数量 = 1,
        减少原有数量 = 2,
        亦进亦出 = 3
    }

    public enum WarehouseKeeperType
    {
        值仓员 = 1,
        保管员 = 2
    }

    public enum Structure
    {
        钢筋砼 = 1,
        砖混 = 2,
        钢板 = 3,
        其它 = 9
    }

    public enum WarehouseBillStatus
    {
        新建 = 1,
        提交 = 2,
        确认 = 3,
        废除 = 99,
        已结转 = 4
    }

    public enum UploadType
    {
        集团 = 1,
        县 = 2,
        市 = 3,
        省 = 4,
        国家 = 5
    }

    public enum WarehouseAmountTransDetailExternalRecordSource
    {
        PlanTaskBatch = 1,
        WarehouseManualRecordDetail = 2,
        ManuPlanTaskBatch = 3
    }

    public enum OperationContent
    {
        保存 = 1,
        提交 = 2,
        确认 = 3,
        撤销 = 4,
        回滚 = 5,
        更新 = 6,
        打印 = 7,
        删除 = 9,
        修改明细 = 10,
        删除明细 = 11
    }
    public enum WarehouseManualRecordExternalSource
    {
        采购 = 1,
        销售 = 2,
        WeighingRecordMaster = 3
    }

    public enum TrafficType
    {
        车运 = 1,
        船运 = 2,
        铁路 = 3
    }
    #endregion

    #region 称重管理
    public enum WeighingBillStatus
    {
        未完成 = 1,
        已完成 = 2,
        废除 = 99
    }

    public enum WeighingEquipmentType
    {
        仅地磅 = 1,
        仅流量秤 = 2,
        地磅和流量秤混合 = 3
    }

    public enum WeighingRecordExternalSource
    {
        PlanTaskBatch = 1,
        WarehouseManualRecordMaster = 2,
        ManuPlanTaskBatch = 3,
        EnrolmentInfo = 4,
        WeighingMaster = 5
    }

    public enum WeightMode
    {
        先毛后皮 = 1,
        先皮后毛 = 2,
        一皮多毛 = 3,
        多毛一皮 = 4
    }
    #endregion

    #region 设备管理
    /// <summary>
    /// 设备状态
    /// </summary>
    public enum EquipmentStatus
    {
        可使用 = 1,
        保养 = 2,
        检修 = 3,
        大修 = 4,
        运行 = 5,
        停用 = 6,
        报废 = 99
    }

    //public enum MaintenancePeriodType
    //{
    //    按日期保养 = 1,
    //    按运行时间保养 = 2
    //}

    public enum EquipmentCodeType
    {
        维护原因大类 = 1,
        维护应对措施 = 2
    }

    public enum MaintenancePeriodType
    {
        按日期保养 = 1,
        按运行时间保养 = 2,
        按日期及运行时间最近值 = 3
    }

    public enum MaintainPlanStatus
    {
        新建 = 1,
        提交 = 2,
        确认 = 3,
        执行 = 4,
        完成 = 5
    }

    public enum EquipmentCategory
    {
        设备类型 = 1,
        仪表类型 = 2
    }
    #endregion

    #region 质量管理
    /// <summary>
    /// 化验单状态
    /// </summary>
    public enum AssayMasterStatus
    {
        等待化验 = 1,
        化验中 = 2,
        化验完成 = 3
    }

    /// <summary>
    /// 
    /// </summary>
    public enum DeductType
    {
        百分比扣量 = 1,
        直接扣量 = 2,
        百分比扣价 =3,
        直接扣价=4
    }

    /// <summary>
    /// 增量类型
    /// </summary>
    public enum IncreaseType
    {
        百分比扣量 = 1,
        直接扣量 = 2
    }

    /// <summary>
    /// 比较方式
    /// </summary>
    public enum CompareType
    {
        大于 = 1,
        大于等于 = 2,
        等于 = 3,
        小于 = 4,
        小于等于 = 5,
        不等于 = 6,
        区间 = 7
    }

    /// <summary>
    /// 下一指标项组合方式
    /// </summary>
    public enum NextCompareFlag
    {
        or = 1,
        and = 2
    }
    public enum QualityBaseCodeType
    {
        文本型检化验指标 = 1,
        取样方式 = 2,
        化验结果来源 = 3
    }
    public enum QualityBaseConfigAssayFinalResultGenerateWay
    {
        最后一次检验 = 0,
        平均值 = 1,
        最优值 = 2,
        首次值 = 3,
        自选 = 4
    }
    #endregion

    #region 生产管理
    /// <summary>
    /// 生产计划状态
    /// </summary>
    public enum ManuPlanTaskStatus
    {

        草拟 = 1,
        提交 = 2,
        废除 = 3,
        确认 = 4,
        下达 = 5,
        执行 = 6,
        暂停 = 7,
        终止 = 8,
        完成 = 9
    }

    /// <summary>
    /// 计划批次状态
    /// </summary>
    public enum ManuPlanTaskBatchStatus
    {

        下达 = 1,
        执行 = 2,
        暂停 = 3,
        终止 = 4,
        完成 = 5

    }

    /// <summary>
    /// 计划类别类型
    /// </summary>
    public enum PlanTaskMode
    {

        出入库计划 = 1,
        生产计划 = 2

    }
    #endregion

    #region 物料管理
    public enum MaterialCodeType
    {
        货品性质 = 1,
        粮权属性 = 2
    }
    #endregion

    #region 结算管理
    public enum DeductValueSource
    {
        自动扣量 = 1,
        默认扣量 = 2,
        合同扣量 = 3,
        其他 = 4
    }
    public enum SettlementBillStatus
    {

        保存 = 1,
        提交 = 2,
        确认 = 3,
        废除 = 9,
        已结转 = 4

    }//end SettlementBillStatus

    public enum TotalDeductionGenerateWay
    {

        先计数保留后合计 = 1,
        先合计后计数保留 = 2

    }//end TotalDeductionGenerateWay
    #endregion

    #region 统计信息
    public enum StatBillStatus
    {
        新建 = 1,
        已结转 = 2
    }
    #endregion

    #region 报港管理
    public enum EnrolmentBillStatus
    {
        保存 = 1,
        确认 = 2,
        完成 = 3,
        终止 = 4,
        废除 = 5
    }

    public enum EnrolmentQueuingRecordStatus
    {
        待叫号 = 1,
        已叫号未处理 = 2,
        已叫号已扫描 = 3,
        已处理 = 4,
        已放弃 = 5,
    }
    #endregion

    #region 物流运输管理
    public enum InnerVehicleStatus
    {
        可使用 = 1,
        保养 = 2,
        检修 = 3,
        大修 = 4,
        使用中 = 5,
        已停用 = 6,
        报废 = 99
    }
    #endregion

    #region 常量
    public class AisinoConst
    {
        //红冲入库
        public const int HCRK = 1;

        //红冲出库
        public const int HCCK = 1;
    }
    #endregion

    #region 扦样化验
    public enum TestResultSource
    {
        人工录入 = 1,
        设备产生 = 2
    }
    #endregion

    #region 生产经营管理
    public enum CustomerCategory
    {
        客户 = 1,
        供应商 = 2
    }
    public enum CustomerType
    {
        散户 = 1,
        经纪人 = 2,
        大客户 = 3,
        企业 = 4
    }

    public enum ContractStatus
    {
        新建 = 1,
        提交 = 2,
        确认 = 3,
        变更 = 4,
        完成 = 5,
        终止 = 6,
        废除 = 9
    }

    public enum CredentialsStatus
    {

        新建 = 1,
        提交 = 2,
        确认 = 3,
        完成 = 4,
        废除 = 9

    }

    public enum AcquireSeason
    {
        夏 = 1,
        秋 = 2
    }
    #endregion

}
